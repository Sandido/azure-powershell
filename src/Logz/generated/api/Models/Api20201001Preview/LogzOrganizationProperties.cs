// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.Extensions;

    public partial class LogzOrganizationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzOrganizationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzOrganizationPropertiesInternal
    {

        /// <summary>Backing field for <see cref="CompanyName" /> property.</summary>
        private string _companyName;

        /// <summary>Name of the Logz organization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Origin(Microsoft.Azure.PowerShell.Cmdlets.Logz.PropertyOrigin.Owned)]
        public string CompanyName { get => this._companyName; set => this._companyName = value; }

        /// <summary>Backing field for <see cref="EnterpriseAppId" /> property.</summary>
        private string _enterpriseAppId;

        /// <summary>The Id of the Enterprise App used for Single sign on.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Origin(Microsoft.Azure.PowerShell.Cmdlets.Logz.PropertyOrigin.Owned)]
        public string EnterpriseAppId { get => this._enterpriseAppId; set => this._enterpriseAppId = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Id of the Logz organization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Origin(Microsoft.Azure.PowerShell.Cmdlets.Logz.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzOrganizationPropertiesInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Backing field for <see cref="SingleSignOnUrl" /> property.</summary>
        private string _singleSignOnUrl;

        /// <summary>The login URL specific to this Logz Organization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Origin(Microsoft.Azure.PowerShell.Cmdlets.Logz.PropertyOrigin.Owned)]
        public string SingleSignOnUrl { get => this._singleSignOnUrl; set => this._singleSignOnUrl = value; }

        /// <summary>Creates an new <see cref="LogzOrganizationProperties" /> instance.</summary>
        public LogzOrganizationProperties()
        {

        }
    }
    public partial interface ILogzOrganizationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.IJsonSerializable
    {
        /// <summary>Name of the Logz organization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the Logz organization.",
        SerializedName = @"companyName",
        PossibleTypes = new [] { typeof(string) })]
        string CompanyName { get; set; }
        /// <summary>The Id of the Enterprise App used for Single sign on.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Id of the Enterprise App used for Single sign on.",
        SerializedName = @"enterpriseAppId",
        PossibleTypes = new [] { typeof(string) })]
        string EnterpriseAppId { get; set; }
        /// <summary>Id of the Logz organization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Id of the Logz organization.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>The login URL specific to this Logz Organization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The login URL specific to this Logz Organization.",
        SerializedName = @"singleSignOnUrl",
        PossibleTypes = new [] { typeof(string) })]
        string SingleSignOnUrl { get; set; }

    }
    internal partial interface ILogzOrganizationPropertiesInternal

    {
        /// <summary>Name of the Logz organization.</summary>
        string CompanyName { get; set; }
        /// <summary>The Id of the Enterprise App used for Single sign on.</summary>
        string EnterpriseAppId { get; set; }
        /// <summary>Id of the Logz organization.</summary>
        string Id { get; set; }
        /// <summary>The login URL specific to this Logz Organization.</summary>
        string SingleSignOnUrl { get; set; }

    }
}