
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
Gets information about the specified network function resource.
.Description
Gets information about the specified network function resource.
.Example
PS C:\> Get-AzConnectedNetworkFunction -Name myVnf -ResourceGroupName myResources


ContainerConfiguration       : Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.NetworkFunctionPropertiesFormatNetworkFunctionContainerConfigurations
DeviceId                     : /subscriptions/xxxxx-00000-xxxxx-00000/resourceGroups/myResources/providers/Microsoft.HybridNetwork/devices/myMec
Etag                         : "0000a530-0000-3400-0000-615c10fa0000"
Id                           : /subscriptions/xxxxx-00000-xxxxx-00000/resourceGroups/myResources/providers/Microsoft.HybridNetwork/networkFunctions/myVnf
Location                     : centraluseuap
ManagedApplicationId         :
ManagedApplicationParameter  : Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.NetworkFunctionPropertiesFormatManagedApplicationParameters
Name                         : myVnf
ProvisioningState            : Failed
ResourceGroupName            : myResources
ServiceKey                   : 397a7415-ec52-46b5-892b-f840ba491aab
SkuName                      : mySku1
SkuType                      : EvolvedPacketCore
SystemDataCreatedAt          : 10/5/2021 8:45:49 AM
SystemDataCreatedBy          : user@microsoft.com
SystemDataCreatedByType      : User
SystemDataLastModifiedAt     : 10/5/2021 8:46:49 AM
SystemDataLastModifiedBy     : xxxxx-11111-xxxxx-11111
SystemDataLastModifiedByType : Application
Tag                          : Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20.TrackedResourceTags
Type                         : microsoft.hybridnetwork/networkfunctions
UserConfiguration            : {hpehss}
VendorName                   : AffirmedVendor
VendorProvisioningState      : NotProvisioned

.Example
PS C:\> $vnf = @{ NetworkFunctionName = "myVnf1"; ResourceGroupName = "myResources"; SubscriptionId = "xxxxx-00000-xxxxx-00000"}
PS C:\> Get-AzConnectedNetworkFunction -InputObject $vnf


ContainerConfiguration       : Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.NetworkFunctionPropertiesFormatNetworkFunctionContainerConfigurations
DeviceId                     : /subscriptions/xxxxx-00000-xxxxx-00000/resourceGroups/myResources/providers/Microsoft.HybridNetwork/devices/myMec1
Etag                         : "sampleEtagValue"
Id                           : /subscriptions/xxxxx-00000-xxxxx-00000/resourceGroups/myResources/providers/Microsoft.HybridNetwork/networkFunctions/myVnf1
Location                     : eastus
ManagedApplicationId         :
ManagedApplicationParameter  : Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.NetworkFunctionPropertiesFormatManagedApplicationParameters
Name                         : myVnf1
ProvisioningState            : Succeeded
ResourceGroupName            : myResources
ServiceKey                   : aa11-bb22-cc33-dd44
SkuName                      : mySku
SkuType                      : EvolvedPacketCore
SystemDataCreatedAt          : 11/1/2021 11:13:57 AM
SystemDataCreatedBy          : user@microsoft.com
SystemDataCreatedByType      : User
SystemDataLastModifiedAt     : 11/15/2021 4:53:08 AM
SystemDataLastModifiedBy     : xxxxx-11111-xxxxx-11111
SystemDataLastModifiedByType : Application
Tag                          : Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20.TrackedResourceTags
Type                         : microsoft.hybridnetwork/networkfunctions
UserConfiguration            : {hpehss}
VendorName                   : AffirmedVendor
VendorProvisioningState      : Provisioned


.Inputs
Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.IConnectedNetworkIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.INetworkFunction
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IConnectedNetworkIdentity>: Identity Parameter
  [DeviceName <String>]: The name of the device resource.
  [Id <String>]: Resource identity path
  [LocationName <String>]: The Azure region where the network function resource was created by the customer.
  [NetworkFunctionName <String>]: The name of the network function.
  [PreviewSubscription <String>]: Preview subscription ID.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [RoleInstanceName <String>]: The name of the role instance of the vendor network function.
  [ServiceKey <String>]: The GUID for the vendor network function.
  [SkuName <String>]: The name of the sku.
  [SubscriptionId <String>]: The ID of the target subscription.
  [VendorName <String>]: The name of the vendor.
  [VendorSkuName <String>]: The name of the network function sku.
.Link
https://docs.microsoft.com/powershell/module/az.connectednetwork/get-azconnectednetworkfunction
#>
function Get-AzConnectedNetworkFunction {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.INetworkFunction])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('NetworkFunctionName')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Path')]
    [System.String]
    # The name of the network function resource.
    ${Name},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List1', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Parameter(ParameterSetName='List1')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.IConnectedNetworkIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Runtime')]
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
            Get = 'Az.ConnectedNetwork.private\Get-AzConnectedNetworkFunction_Get';
            GetViaIdentity = 'Az.ConnectedNetwork.private\Get-AzConnectedNetworkFunction_GetViaIdentity';
            List = 'Az.ConnectedNetwork.private\Get-AzConnectedNetworkFunction_List';
            List1 = 'Az.ConnectedNetwork.private\Get-AzConnectedNetworkFunction_List1';
        }
        if (('Get', 'List', 'List1') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
