// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.EventHub.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.Azure.Management.EventHub.Models;

    /// <summary>
    /// Description of NetworkRuleSet resource.
    /// </summary>
    public class PSNetworkRuleSetAttributes
    {
        /// <summary>
        /// Initializes a new instance of the NetworkRuleSet class.
        /// </summary>
        public PSNetworkRuleSetAttributes()
        {
            IpRules = new List<PSNWRuleSetIpRulesAttributes>();
            VirtualNetworkRules = new List<PSNWRuleSetVirtualNetworkRulesAttributes>();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkRuleSet class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="defaultAction">Default Action for Network Rule Set.
        /// Possible values include: 'Allow', 'Deny'</param>
        /// <param name="VirtualNetworkRules">List VirtualNetwork Rules</param>
        /// <param name="ipRules">List of IpRules</param>
        public PSNetworkRuleSetAttributes(NetworkRuleSet networkRuleSet)           
        {
            DefaultAction = networkRuleSet.DefaultAction;
            TrustedServiceAccessEnabled = networkRuleSet.TrustedServiceAccessEnabled;
            VirtualNetworkRules = PSNWRuleSetVirtualNetworkRulesAttributes.PSNWRuleSetVirtualNetworkRulesAttributesCollection(networkRuleSet.VirtualNetworkRules);
            IpRules = PSNWRuleSetIpRulesAttributes.PSNWRuleSetIpRulesAttributesCollection(networkRuleSet.IpRules);
            Id = networkRuleSet.Id;
            Name = networkRuleSet.Name;
            Type = networkRuleSet.Type;
            PublicNetworkAccess = networkRuleSet?.PublicNetworkAccess;
        }

        /// <summary>
        /// Gets or sets the Id of the Namespace
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the Type of the Namespace
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the name of the Namespace
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets default Action for Network Rule Set. Possible values
        /// include: 'Allow', 'Deny'
        /// </summary>
        public string DefaultAction { get; set; }

        /// <summary>
        /// Gets or sets list VirtualNetwork Rules
        /// </summary>
        public IList<PSNWRuleSetVirtualNetworkRulesAttributes> VirtualNetworkRules { get; set; }

        /// <summary>
        /// Gets or sets list of IpRules
        /// </summary>
        public IList<PSNWRuleSetIpRulesAttributes> IpRules { get; set; }

        public bool? TrustedServiceAccessEnabled { get; set; }

        public string PublicNetworkAccess { get; set; }

    }
}
