// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301
{
    using Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.PowerShell;

    /// <summary>Pool of backend IP addresses.</summary>
    [System.ComponentModel.TypeConverter(typeof(BackendAddressPoolTypeConverter))]
    public partial class BackendAddressPool
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.BackendAddressPool"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal BackendAddressPool(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolPropertiesFormat) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.BackendAddressPoolPropertiesFormatTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Etag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).Etag = (string) content.GetValueForProperty("Etag",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).Etag, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGeneratedInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGeneratedInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("OutboundRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).OutboundRule = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGenerated) content.GetValueForProperty("OutboundRule",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).OutboundRule, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.SubResourceAutoGeneratedTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("TunnelInterface"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).TunnelInterface = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IGatewayLoadBalancerTunnelInterface[]) content.GetValueForProperty("TunnelInterface",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).TunnelInterface, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IGatewayLoadBalancerTunnelInterface>(__y, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.GatewayLoadBalancerTunnelInterfaceTypeConverter.ConvertFrom));
            }
            if (content.Contains("LoadBalancerBackendAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).LoadBalancerBackendAddress = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ILoadBalancerBackendAddress[]) content.GetValueForProperty("LoadBalancerBackendAddress",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).LoadBalancerBackendAddress, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ILoadBalancerBackendAddress>(__y, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.LoadBalancerBackendAddressTypeConverter.ConvertFrom));
            }
            if (content.Contains("BackendIPConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).BackendIPConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkInterfaceIPConfiguration[]) content.GetValueForProperty("BackendIPConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).BackendIPConfiguration, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkInterfaceIPConfiguration>(__y, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.NetworkInterfaceIPConfigurationTypeConverter.ConvertFrom));
            }
            if (content.Contains("LoadBalancingRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).LoadBalancingRule = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGenerated[]) content.GetValueForProperty("LoadBalancingRule",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).LoadBalancingRule, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGenerated>(__y, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.SubResourceAutoGeneratedTypeConverter.ConvertFrom));
            }
            if (content.Contains("PropertiesOutboundRules"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).PropertiesOutboundRules = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGenerated[]) content.GetValueForProperty("PropertiesOutboundRules",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).PropertiesOutboundRules, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGenerated>(__y, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.SubResourceAutoGeneratedTypeConverter.ConvertFrom));
            }
            if (content.Contains("OutboundRuleId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).OutboundRuleId = (string) content.GetValueForProperty("OutboundRuleId",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).OutboundRuleId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.BackendAddressPool"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal BackendAddressPool(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolPropertiesFormat) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.BackendAddressPoolPropertiesFormatTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Etag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).Etag = (string) content.GetValueForProperty("Etag",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).Etag, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGeneratedInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGeneratedInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("OutboundRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).OutboundRule = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGenerated) content.GetValueForProperty("OutboundRule",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).OutboundRule, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.SubResourceAutoGeneratedTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("TunnelInterface"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).TunnelInterface = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IGatewayLoadBalancerTunnelInterface[]) content.GetValueForProperty("TunnelInterface",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).TunnelInterface, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IGatewayLoadBalancerTunnelInterface>(__y, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.GatewayLoadBalancerTunnelInterfaceTypeConverter.ConvertFrom));
            }
            if (content.Contains("LoadBalancerBackendAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).LoadBalancerBackendAddress = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ILoadBalancerBackendAddress[]) content.GetValueForProperty("LoadBalancerBackendAddress",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).LoadBalancerBackendAddress, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ILoadBalancerBackendAddress>(__y, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.LoadBalancerBackendAddressTypeConverter.ConvertFrom));
            }
            if (content.Contains("BackendIPConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).BackendIPConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkInterfaceIPConfiguration[]) content.GetValueForProperty("BackendIPConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).BackendIPConfiguration, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkInterfaceIPConfiguration>(__y, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.NetworkInterfaceIPConfigurationTypeConverter.ConvertFrom));
            }
            if (content.Contains("LoadBalancingRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).LoadBalancingRule = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGenerated[]) content.GetValueForProperty("LoadBalancingRule",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).LoadBalancingRule, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGenerated>(__y, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.SubResourceAutoGeneratedTypeConverter.ConvertFrom));
            }
            if (content.Contains("PropertiesOutboundRules"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).PropertiesOutboundRules = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGenerated[]) content.GetValueForProperty("PropertiesOutboundRules",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).PropertiesOutboundRules, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGenerated>(__y, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.SubResourceAutoGeneratedTypeConverter.ConvertFrom));
            }
            if (content.Contains("OutboundRuleId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).OutboundRuleId = (string) content.GetValueForProperty("OutboundRuleId",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPoolInternal)this).OutboundRuleId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.BackendAddressPool"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPool" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPool DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new BackendAddressPool(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.BackendAddressPool"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPool" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPool DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new BackendAddressPool(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="BackendAddressPool" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPool FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Pool of backend IP addresses.
    [System.ComponentModel.TypeConverter(typeof(BackendAddressPoolTypeConverter))]
    public partial interface IBackendAddressPool

    {

    }
}