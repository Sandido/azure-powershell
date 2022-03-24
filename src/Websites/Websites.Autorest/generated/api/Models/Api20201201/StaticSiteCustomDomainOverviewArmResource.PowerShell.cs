// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201
{
    using Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.PowerShell;

    /// <summary>Static Site Custom Domain Overview ARM resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(StaticSiteCustomDomainOverviewArmResourceTypeConverter))]
    public partial class StaticSiteCustomDomainOverviewArmResource
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
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.StaticSiteCustomDomainOverviewArmResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteCustomDomainOverviewArmResource"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteCustomDomainOverviewArmResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new StaticSiteCustomDomainOverviewArmResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.StaticSiteCustomDomainOverviewArmResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteCustomDomainOverviewArmResource"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteCustomDomainOverviewArmResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new StaticSiteCustomDomainOverviewArmResource(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="StaticSiteCustomDomainOverviewArmResource" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteCustomDomainOverviewArmResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.StaticSiteCustomDomainOverviewArmResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal StaticSiteCustomDomainOverviewArmResource(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteCustomDomainOverviewArmResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteCustomDomainOverviewArmResourceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteCustomDomainOverviewArmResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.StaticSiteCustomDomainOverviewArmResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Kind = (string) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Kind, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("DomainName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteCustomDomainOverviewArmResourceInternal)this).DomainName = (string) content.GetValueForProperty("DomainName",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteCustomDomainOverviewArmResourceInternal)this).DomainName, global::System.Convert.ToString);
            }
            if (content.Contains("CreatedOn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteCustomDomainOverviewArmResourceInternal)this).CreatedOn = (global::System.DateTime?) content.GetValueForProperty("CreatedOn",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteCustomDomainOverviewArmResourceInternal)this).CreatedOn, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteCustomDomainOverviewArmResourceInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.CustomDomainStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteCustomDomainOverviewArmResourceInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.CustomDomainStatus.CreateFrom);
            }
            if (content.Contains("ValidationToken"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteCustomDomainOverviewArmResourceInternal)this).ValidationToken = (string) content.GetValueForProperty("ValidationToken",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteCustomDomainOverviewArmResourceInternal)this).ValidationToken, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteCustomDomainOverviewArmResourceInternal)this).ErrorMessage = (string) content.GetValueForProperty("ErrorMessage",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteCustomDomainOverviewArmResourceInternal)this).ErrorMessage, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.StaticSiteCustomDomainOverviewArmResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal StaticSiteCustomDomainOverviewArmResource(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteCustomDomainOverviewArmResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteCustomDomainOverviewArmResourceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteCustomDomainOverviewArmResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.StaticSiteCustomDomainOverviewArmResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Kind = (string) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Kind, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("DomainName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteCustomDomainOverviewArmResourceInternal)this).DomainName = (string) content.GetValueForProperty("DomainName",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteCustomDomainOverviewArmResourceInternal)this).DomainName, global::System.Convert.ToString);
            }
            if (content.Contains("CreatedOn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteCustomDomainOverviewArmResourceInternal)this).CreatedOn = (global::System.DateTime?) content.GetValueForProperty("CreatedOn",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteCustomDomainOverviewArmResourceInternal)this).CreatedOn, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteCustomDomainOverviewArmResourceInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.CustomDomainStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteCustomDomainOverviewArmResourceInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.CustomDomainStatus.CreateFrom);
            }
            if (content.Contains("ValidationToken"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteCustomDomainOverviewArmResourceInternal)this).ValidationToken = (string) content.GetValueForProperty("ValidationToken",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteCustomDomainOverviewArmResourceInternal)this).ValidationToken, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteCustomDomainOverviewArmResourceInternal)this).ErrorMessage = (string) content.GetValueForProperty("ErrorMessage",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteCustomDomainOverviewArmResourceInternal)this).ErrorMessage, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Static Site Custom Domain Overview ARM resource.
    [System.ComponentModel.TypeConverter(typeof(StaticSiteCustomDomainOverviewArmResourceTypeConverter))]
    public partial interface IStaticSiteCustomDomainOverviewArmResource

    {

    }
}