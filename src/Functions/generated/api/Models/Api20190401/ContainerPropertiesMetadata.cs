// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Extensions;

    /// <summary>A name-value pair to associate with the container as metadata.</summary>
    public partial class ContainerPropertiesMetadata :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IContainerPropertiesMetadata,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IContainerPropertiesMetadataInternal
    {

        /// <summary>Creates an new <see cref="ContainerPropertiesMetadata" /> instance.</summary>
        public ContainerPropertiesMetadata()
        {

        }
    }
    /// A name-value pair to associate with the container as metadata.
    public partial interface IContainerPropertiesMetadata :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IAssociativeArray<string>
    {

    }
    /// A name-value pair to associate with the container as metadata.
    internal partial interface IContainerPropertiesMetadataInternal

    {

    }
}