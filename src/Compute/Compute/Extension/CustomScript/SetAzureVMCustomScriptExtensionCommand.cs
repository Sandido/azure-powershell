[Cmdlet("Set", "AzVMCustomScriptExtension")]
param(
    [Parameter(Mandatory=$true)]
    [string]$ResourceGroupName,

    [Parameter(Mandatory=$true)]
    [string]$VMName,

    [Parameter(Mandatory=$true)]
    [string]$Location,

    [Parameter(Mandatory=$true)]
    [string]$StorageAccountName,

    [Parameter(Mandatory=$true)]
    [string]$StorageAccountKey,

    [Parameter(Mandatory=$true)]
    [string]$FileName,

    [Parameter(Mandatory=$true)]
    [string]$ContainerName,

    [Parameter(Mandatory=$false)]
    [string]$CommandToExecute
)

# New parameters
[Parameter(Mandatory=$false, HelpMessage = "Managed Identity parameter")]
public Hashtable ManagedIdentity { get; set; }

[Parameter(Mandatory=$false, HelpMessage = "Skip Dos2Unix parameter")]
public SwitchParameter SkipDos2Unix { get; set; }

[Parameter(Mandatory=$false, HelpMessage = "Script parameter")]
public string Script { get; set; }

# Existing code
$StorageContext = New-AzStorageContext -StorageAccountName $StorageAccountName -StorageAccountKey $StorageAccountKey
$ScriptFile = Set-AzStorageBlobContent -File $FileName -Container $ContainerName -Blob $FileName -Context $StorageContext -Force

# Updated code
$PublicSettings = @{
    "fileUris" = @( $ScriptFile.ICloudBlob.Uri.AbsoluteUri );
    "commandToExecute" = $CommandToExecute;
    "skipDos2Unix" = $SkipDos2Unix.IsPresent;
}

$ProtectedSettings = @{
    "storageAccountName" = $StorageAccountName;
    "storageAccountKey" = $StorageAccountKey;
    "managedIdentity" = $ManagedIdentity;
    "script" = $Script;
}

Set-AzVMExtension -ResourceGroupName $ResourceGroupName -VMName $VMName -Location $Location -Publisher "Microsoft.Compute" -ExtensionType "CustomScriptExtension" -TypeHandlerVersion "2.0" -Setting $PublicSettings -ProtectedSetting $ProtectedSettings -Name "CustomScriptExtension"