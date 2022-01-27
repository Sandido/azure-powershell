﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------
using Microsoft.Azure.Commands.ServiceBus.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Internal.Resources.Utilities.Models;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.ServiceBus.Commands.NetworkruleSet
{
    /// <summary>
    /// 'Set-AzEventHubNamespace' Cmdlet updates the specified Eventhub Namespace
    /// </summary>
    [Cmdlet("Set", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "ServiceBusNetworkRuleSet", SupportsShouldProcess = true, DefaultParameterSetName = NetwrokruleSetPropertiesParameterSet), OutputType(typeof(PSNetworkRuleSetAttributes))]
    public class SetAzureServiceBusNetworkrule : AzureServiceBusCmdletBase
    {
        [Parameter(Mandatory = true, ParameterSetName = NetwrokruleSetInputObjectParameterSet, Position = 0, HelpMessage = "Resource Group Name.")]
        [Parameter(Mandatory = true, ParameterSetName = NetwrokruleSetPropertiesParameterSet, Position = 0, HelpMessage = "Resource Group Name.")]
        [Parameter(Mandatory = true, ParameterSetName = NetworkRuleSetResourceIdParameterSet, Position = 0, HelpMessage = "Resource Group Name.")]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
         public string ResourceGroupName { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = NetwrokruleSetInputObjectParameterSet, Position = 1, HelpMessage = "ServiceBus Namespace Name.")]
        [Parameter(Mandatory = true, ParameterSetName = NetwrokruleSetPropertiesParameterSet, Position = 1, HelpMessage = "ServiceBus Namespace Name.")]
        [Parameter(Mandatory = true, ParameterSetName = NetworkRuleSetResourceIdParameterSet, Position = 1, HelpMessage = "ServiceBus Namespace Name.")]
        [ValidateNotNullOrEmpty]
        [Alias(AliasNamespaceName)]
        public string Name { get; set; }       

        [Parameter(Mandatory = false, ParameterSetName = NetwrokruleSetPropertiesParameterSet, HelpMessage = "Default Action for NetwrokeuleSet")]
        [PSArgumentCompleter("Allow", "Deny")]
        [PSDefaultValue(Value ="Deny")]
        public string DefaultAction { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = NetwrokruleSetPropertiesParameterSet, HelpMessage = "Public Network Access for NetwrokeuleSet")]
        [PSArgumentCompleter("Enabled", "Disabled")]
        [PSDefaultValue(Value = "Enabled")]
        public string PublicNetworkAccess { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = NetwrokruleSetPropertiesParameterSet, Position = 2, HelpMessage = "List of IPRuleSet")]
        [ValidateNotNullOrEmpty]
        public PSNWRuleSetIpRulesAttributes[] IPRule { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = NetwrokruleSetPropertiesParameterSet, Position = 3, HelpMessage = "List of VirtualNetworkRules")]
        [ValidateNotNullOrEmpty]
        [Alias(AliasVirtualNetworkRule)]
        public PSNWRuleSetVirtualNetworkRulesAttributes[] VirtualNetworkRule { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = NetwrokruleSetInputObjectParameterSet, ValueFromPipeline = true, Position = 2, HelpMessage = "NetworkruleSet Configuration Object")]
        [ValidateNotNullOrEmpty]
        public PSNetworkRuleSetAttributes InputObject { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = NetworkRuleSetResourceIdParameterSet, ValueFromPipelineByPropertyName = true, Position = 2, HelpMessage = "Resource ID of Namespace")]
        [ValidateNotNullOrEmpty]
        public string ResourceId { get; set; }


        public override void ExecuteCmdlet()
        {
            // Update the NetworlruleSet 
            
            if (ShouldProcess(target: Name, action: string.Format("Update NetworkruleSet for {0} Namespace in {1} ResourceGroup", Name, ResourceGroupName)))
            {
                try
                {

                    if (ParameterSetName.Equals(NetwrokruleSetPropertiesParameterSet))
                    {
                        PSNetworkRuleSetAttributes networkRuleSetAttributes = new PSNetworkRuleSetAttributes()
                        {
                            DefaultAction = DefaultAction,
                            IpRules = IPRule.OfType<PSNWRuleSetIpRulesAttributes>().ToList(),
                            VirtualNetworkRules = VirtualNetworkRule.OfType<PSNWRuleSetVirtualNetworkRulesAttributes>().ToList(),
                            PublicNetworkAccess = PublicNetworkAccess
                        };

                        WriteObject(Client.CreateOrUpdateNetworkRuleSet(ResourceGroupName, Name, networkRuleSetAttributes));
                    }

                    if (ParameterSetName.Equals(NetwrokruleSetInputObjectParameterSet))
                    {
                        WriteObject(Client.CreateOrUpdateNetworkRuleSet(ResourceGroupName, Name, InputObject));
                    }

                    if (ParameterSetName.Equals("NetworkRuleSetResourceIdParameterSet"))
                    {
                        ResourceIdentifier getParamGeoDR = GetResourceDetailsFromId(ResourceId);

                        PSNetworkRuleSetAttributes getNWRuleSet = Client.GetNetworkRuleSet(getParamGeoDR.ResourceGroupName, getParamGeoDR.ParentResource);

                        if (ResourceGroupName != null && getParamGeoDR.ResourceName != null)
                        {
                            if (ShouldProcess(target: Name, action: string.Format("updating NetwrokruleSet", Name, ResourceGroupName)))
                            {
                                WriteObject(Client.CreateOrUpdateNetworkRuleSet(ResourceGroupName, Name, getNWRuleSet));
                            }
                        }
                    }
                }
                catch (Management.ServiceBus.Models.ErrorResponseException ex)
                {
                    WriteError(ServiceBusClient.WriteErrorforBadrequest(ex));
                }
            }
        }
    }
}
