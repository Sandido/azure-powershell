// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Extensions;

    /// <summary>Collection of workspace object with a next link</summary>
    public partial class WorkspaceList :
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IWorkspaceList,
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IWorkspaceListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link used to get the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IWorkspace[] _value;

        /// <summary>Collection of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IWorkspace[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="WorkspaceList" /> instance.</summary>
        public WorkspaceList()
        {

        }
    }
    /// Collection of workspace object with a next link
    public partial interface IWorkspaceList :
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.IJsonSerializable
    {
        /// <summary>The link used to get the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The link used to get the next page.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>Collection of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Collection of resources.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IWorkspace) })]
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IWorkspace[] Value { get; set; }

    }
    /// Collection of workspace object with a next link
    internal partial interface IWorkspaceListInternal

    {
        /// <summary>The link used to get the next page.</summary>
        string NextLink { get; set; }
        /// <summary>Collection of resources.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IWorkspace[] Value { get; set; }

    }
}