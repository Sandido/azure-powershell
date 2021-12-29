// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701
{
    using Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.PowerShell;

    /// <summary>This is the storage profile of a Gallery Image Version.</summary>
    [System.ComponentModel.TypeConverter(typeof(GalleryImageVersionStorageProfileTypeConverter))]
    public partial class GalleryImageVersionStorageProfile
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryImageVersionStorageProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfile"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfile DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new GalleryImageVersionStorageProfile(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryImageVersionStorageProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfile"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfile DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new GalleryImageVersionStorageProfile(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="GalleryImageVersionStorageProfile" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfile FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryImageVersionStorageProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal GalleryImageVersionStorageProfile(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).Source = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryArtifactVersionSource) content.GetValueForProperty("Source",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).Source, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryArtifactVersionSourceTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).OSDiskImage = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryDiskImage) content.GetValueForProperty("OSDiskImage",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).OSDiskImage, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryDiskImageTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).DataDiskImage = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryDataDiskImage[]) content.GetValueForProperty("DataDiskImage",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).DataDiskImage, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryDataDiskImage>(__y, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryDataDiskImageTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).OSDiskImageHostCaching = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.HostCaching?) content.GetValueForProperty("OSDiskImageHostCaching",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).OSDiskImageHostCaching, Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.HostCaching.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).Uri = (string) content.GetValueForProperty("Uri",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).Uri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).OSDiskImageSource = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryArtifactVersionSource) content.GetValueForProperty("OSDiskImageSource",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).OSDiskImageSource, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryArtifactVersionSourceTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).OSDiskImageSizeInGb = (int?) content.GetValueForProperty("OSDiskImageSizeInGb",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).OSDiskImageSizeInGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).OSDiskImageSourceId = (string) content.GetValueForProperty("OSDiskImageSourceId",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).OSDiskImageSourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).OSDiskImageSourceUri = (string) content.GetValueForProperty("OSDiskImageSourceUri",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).OSDiskImageSourceUri, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryImageVersionStorageProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal GalleryImageVersionStorageProfile(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).Source = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryArtifactVersionSource) content.GetValueForProperty("Source",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).Source, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryArtifactVersionSourceTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).OSDiskImage = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryDiskImage) content.GetValueForProperty("OSDiskImage",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).OSDiskImage, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryDiskImageTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).DataDiskImage = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryDataDiskImage[]) content.GetValueForProperty("DataDiskImage",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).DataDiskImage, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryDataDiskImage>(__y, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryDataDiskImageTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).OSDiskImageHostCaching = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.HostCaching?) content.GetValueForProperty("OSDiskImageHostCaching",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).OSDiskImageHostCaching, Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.HostCaching.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).Uri = (string) content.GetValueForProperty("Uri",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).Uri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).OSDiskImageSource = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryArtifactVersionSource) content.GetValueForProperty("OSDiskImageSource",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).OSDiskImageSource, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryArtifactVersionSourceTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).OSDiskImageSizeInGb = (int?) content.GetValueForProperty("OSDiskImageSizeInGb",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).OSDiskImageSizeInGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).OSDiskImageSourceId = (string) content.GetValueForProperty("OSDiskImageSourceId",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).OSDiskImageSourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).OSDiskImageSourceUri = (string) content.GetValueForProperty("OSDiskImageSourceUri",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageVersionStorageProfileInternal)this).OSDiskImageSourceUri, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// This is the storage profile of a Gallery Image Version.
    [System.ComponentModel.TypeConverter(typeof(GalleryImageVersionStorageProfileTypeConverter))]
    public partial interface IGalleryImageVersionStorageProfile

    {

    }
}