// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Extensions;

    /// <summary>The common properties of tracked resources in the service.</summary>
    public partial class TaggedResource :
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.ITaggedResource,
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.ITaggedResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.ILocationBasedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.ILocationBasedResource __locationBasedResource = new Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.LocationBasedResource();

        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceTags1"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceTags1 __resourceTags1 = new Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.ResourceTags1();

        /// <summary>
        /// An etag associated with the resource, used for optimistic concurrency when editing it.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Inherited)]
        public string Etag { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceCoreInternal)__locationBasedResource).Etag; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceCoreInternal)__locationBasedResource).Etag = value ?? null; }

        /// <summary>The resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceCoreInternal)__locationBasedResource).Id; }

        /// <summary>The resource location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.ILocationBasedResourceInternal)__locationBasedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.ILocationBasedResourceInternal)__locationBasedResource).Location = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceCoreInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceCoreInternal)__locationBasedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceCoreInternal)__locationBasedResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceCoreInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceCoreInternal)__locationBasedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceCoreInternal)__locationBasedResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceCoreInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceCoreInternal)__locationBasedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceCoreInternal)__locationBasedResource).Type = value; }

        /// <summary>The resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceCoreInternal)__locationBasedResource).Name; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceTags1Internal)__resourceTags1).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceTags1Internal)__resourceTags1).Tag = value ?? null /* model class */; }

        /// <summary>The resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceCoreInternal)__locationBasedResource).Type; }

        /// <summary>Creates an new <see cref="TaggedResource" /> instance.</summary>
        public TaggedResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resourceTags1), __resourceTags1);
            await eventListener.AssertObjectIsValid(nameof(__resourceTags1), __resourceTags1);
            await eventListener.AssertNotNull(nameof(__locationBasedResource), __locationBasedResource);
            await eventListener.AssertObjectIsValid(nameof(__locationBasedResource), __locationBasedResource);
        }
    }
    /// The common properties of tracked resources in the service.
    public partial interface ITaggedResource :
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceTags1,
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.ILocationBasedResource
    {

    }
    /// The common properties of tracked resources in the service.
    internal partial interface ITaggedResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceTags1Internal,
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.ILocationBasedResourceInternal
    {

    }
}