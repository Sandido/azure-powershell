// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Extensions;

    /// <summary>Azure capacity definition.</summary>
    public partial class AzureCapacity :
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAzureCapacity,
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAzureCapacityInternal
    {

        /// <summary>Backing field for <see cref="Default" /> property.</summary>
        private int _default;

        /// <summary>The default capacity that would be used.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Owned)]
        public int Default { get => this._default; set => this._default = value; }

        /// <summary>Backing field for <see cref="Maximum" /> property.</summary>
        private int _maximum;

        /// <summary>Maximum allowed capacity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Owned)]
        public int Maximum { get => this._maximum; set => this._maximum = value; }

        /// <summary>Backing field for <see cref="Minimum" /> property.</summary>
        private int _minimum;

        /// <summary>Minimum allowed capacity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Owned)]
        public int Minimum { get => this._minimum; set => this._minimum = value; }

        /// <summary>Backing field for <see cref="ScaleType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.AzureScaleType _scaleType;

        /// <summary>Scale type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.AzureScaleType ScaleType { get => this._scaleType; set => this._scaleType = value; }

        /// <summary>Creates an new <see cref="AzureCapacity" /> instance.</summary>
        public AzureCapacity()
        {

        }
    }
    /// Azure capacity definition.
    public partial interface IAzureCapacity :
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.IJsonSerializable
    {
        /// <summary>The default capacity that would be used.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The default capacity that would be used.",
        SerializedName = @"default",
        PossibleTypes = new [] { typeof(int) })]
        int Default { get; set; }
        /// <summary>Maximum allowed capacity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Maximum allowed capacity.",
        SerializedName = @"maximum",
        PossibleTypes = new [] { typeof(int) })]
        int Maximum { get; set; }
        /// <summary>Minimum allowed capacity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Minimum allowed capacity.",
        SerializedName = @"minimum",
        PossibleTypes = new [] { typeof(int) })]
        int Minimum { get; set; }
        /// <summary>Scale type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Scale type.",
        SerializedName = @"scaleType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.AzureScaleType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.AzureScaleType ScaleType { get; set; }

    }
    /// Azure capacity definition.
    internal partial interface IAzureCapacityInternal

    {
        /// <summary>The default capacity that would be used.</summary>
        int Default { get; set; }
        /// <summary>Maximum allowed capacity.</summary>
        int Maximum { get; set; }
        /// <summary>Minimum allowed capacity.</summary>
        int Minimum { get; set; }
        /// <summary>Scale type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.AzureScaleType ScaleType { get; set; }

    }
}