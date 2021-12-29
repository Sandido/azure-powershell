// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Extensions;

    /// <summary>
    /// Holds Customer subscription details. Clients can display available products to unregistered customers by explicitly passing
    /// subscription details
    /// </summary>
    public partial class CustomerSubscriptionDetails :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ICustomerSubscriptionDetails,
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ICustomerSubscriptionDetailsInternal
    {

        /// <summary>Backing field for <see cref="LocationPlacementId" /> property.</summary>
        private string _locationPlacementId;

        /// <summary>Location placement Id of a subscription</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public string LocationPlacementId { get => this._locationPlacementId; set => this._locationPlacementId = value; }

        /// <summary>Backing field for <see cref="QuotaId" /> property.</summary>
        private string _quotaId;

        /// <summary>Quota ID of a subscription</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public string QuotaId { get => this._quotaId; set => this._quotaId = value; }

        /// <summary>Backing field for <see cref="RegisteredFeature" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ICustomerSubscriptionRegisteredFeatures[] _registeredFeature;

        /// <summary>List of registered feature flags for subscription</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ICustomerSubscriptionRegisteredFeatures[] RegisteredFeature { get => this._registeredFeature; set => this._registeredFeature = value; }

        /// <summary>Creates an new <see cref="CustomerSubscriptionDetails" /> instance.</summary>
        public CustomerSubscriptionDetails()
        {

        }
    }
    /// Holds Customer subscription details. Clients can display available products to unregistered customers by explicitly passing
    /// subscription details
    public partial interface ICustomerSubscriptionDetails :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.IJsonSerializable
    {
        /// <summary>Location placement Id of a subscription</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Location placement Id of a subscription",
        SerializedName = @"locationPlacementId",
        PossibleTypes = new [] { typeof(string) })]
        string LocationPlacementId { get; set; }
        /// <summary>Quota ID of a subscription</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Quota ID of a subscription",
        SerializedName = @"quotaId",
        PossibleTypes = new [] { typeof(string) })]
        string QuotaId { get; set; }
        /// <summary>List of registered feature flags for subscription</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of registered feature flags for subscription",
        SerializedName = @"registeredFeatures",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ICustomerSubscriptionRegisteredFeatures) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ICustomerSubscriptionRegisteredFeatures[] RegisteredFeature { get; set; }

    }
    /// Holds Customer subscription details. Clients can display available products to unregistered customers by explicitly passing
    /// subscription details
    internal partial interface ICustomerSubscriptionDetailsInternal

    {
        /// <summary>Location placement Id of a subscription</summary>
        string LocationPlacementId { get; set; }
        /// <summary>Quota ID of a subscription</summary>
        string QuotaId { get; set; }
        /// <summary>List of registered feature flags for subscription</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ICustomerSubscriptionRegisteredFeatures[] RegisteredFeature { get; set; }

    }
}