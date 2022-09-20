
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Creates or updates instance.
.Description
Creates or updates instance.
.Example
New-AzDeviceUpdateInstance -AccountName azpstest-account -Name azpstest-instance -ResourceGroupName azpstest_gp -Location eastus -IotHubId "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/azpstest_gp/providers/Microsoft.Devices/IotHubs/azpstest-iothub" -EnableDiagnostic:$false -DiagnosticStoragePropertyResourceId "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/azpstest_gp/providers/Microsoft.Storage/storageAccounts/azpsteststorageaccount" -DiagnosticStoragePropertyConnectionString "De******et"

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IInstance
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

IOTHUB <IIotHubSettings[]>: List of IoT Hubs associated with the account.
  ResourceId <String>: IoTHub resource ID
.Link
https://docs.microsoft.com/powershell/module/az.deviceupdate/new-azdeviceupdateinstance
#>
function New-AzDeviceUpdateInstance {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IInstance])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Category('Path')]
    [System.String]
    # Account name.
    ${AccountName},

    [Parameter(Mandatory)]
    [Alias('InstanceName')]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Category('Path')]
    [System.String]
    # Instance name.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Category('Path')]
    [System.String]
    # The resource group name.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The Azure subscription ID.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Category('Body')]
    [System.String]
    # The geo-location where the resource lives
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Category('Body')]
    [System.String]
    # ConnectionString of the diagnostic storage account
    ${DiagnosticStoragePropertyConnectionString},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Category('Body')]
    [System.String]
    # ResourceId of the diagnostic storage account
    ${DiagnosticStoragePropertyResourceId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Enables or Disables the diagnostic logs collection
    ${EnableDiagnostic},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IIotHubSettings[]]
    # List of IoT Hubs associated with the account.
    # To construct, see NOTES section for IOTHUB properties and create a hash table.
    ${IotHub},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.ITrackedResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName

        $mapping = @{
            CreateExpanded = 'Az.DeviceUpdate.private\New-AzDeviceUpdateInstance_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }

        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {

        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {

        throw
    }

}
end {
    try {
        $steppablePipeline.End()

    } catch {

        throw
    }
} 
}
