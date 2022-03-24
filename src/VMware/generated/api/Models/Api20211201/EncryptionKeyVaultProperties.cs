// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Extensions;

    /// <summary>An Encryption Key</summary>
    public partial class EncryptionKeyVaultProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IEncryptionKeyVaultProperties,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IEncryptionKeyVaultPropertiesInternal
    {

        /// <summary>Backing field for <see cref="KeyName" /> property.</summary>
        private string _keyName;

        /// <summary>The name of the key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public string KeyName { get => this._keyName; set => this._keyName = value; }

        /// <summary>Backing field for <see cref="KeyState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.EncryptionKeyStatus? _keyState;

        /// <summary>The state of key provided</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.EncryptionKeyStatus? KeyState { get => this._keyState; }

        /// <summary>Backing field for <see cref="KeyVaultUrl" /> property.</summary>
        private string _keyVaultUrl;

        /// <summary>The URL of the vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public string KeyVaultUrl { get => this._keyVaultUrl; set => this._keyVaultUrl = value; }

        /// <summary>Backing field for <see cref="KeyVersion" /> property.</summary>
        private string _keyVersion;

        /// <summary>The version of the key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public string KeyVersion { get => this._keyVersion; set => this._keyVersion = value; }

        /// <summary>Internal Acessors for KeyState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.EncryptionKeyStatus? Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IEncryptionKeyVaultPropertiesInternal.KeyState { get => this._keyState; set { {_keyState = value;} } }

        /// <summary>Internal Acessors for VersionType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.EncryptionVersionType? Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IEncryptionKeyVaultPropertiesInternal.VersionType { get => this._versionType; set { {_versionType = value;} } }

        /// <summary>Backing field for <see cref="VersionType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.EncryptionVersionType? _versionType;

        /// <summary>Property of the key if user provided or auto detected</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.EncryptionVersionType? VersionType { get => this._versionType; }

        /// <summary>Creates an new <see cref="EncryptionKeyVaultProperties" /> instance.</summary>
        public EncryptionKeyVaultProperties()
        {

        }
    }
    /// An Encryption Key
    public partial interface IEncryptionKeyVaultProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IJsonSerializable
    {
        /// <summary>The name of the key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the key.",
        SerializedName = @"keyName",
        PossibleTypes = new [] { typeof(string) })]
        string KeyName { get; set; }
        /// <summary>The state of key provided</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The state of key provided",
        SerializedName = @"keyState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.EncryptionKeyStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.EncryptionKeyStatus? KeyState { get;  }
        /// <summary>The URL of the vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URL of the vault.",
        SerializedName = @"keyVaultUrl",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultUrl { get; set; }
        /// <summary>The version of the key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The version of the key.",
        SerializedName = @"keyVersion",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVersion { get; set; }
        /// <summary>Property of the key if user provided or auto detected</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Property of the key if user provided or auto detected",
        SerializedName = @"versionType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.EncryptionVersionType) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.EncryptionVersionType? VersionType { get;  }

    }
    /// An Encryption Key
    internal partial interface IEncryptionKeyVaultPropertiesInternal

    {
        /// <summary>The name of the key.</summary>
        string KeyName { get; set; }
        /// <summary>The state of key provided</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.EncryptionKeyStatus? KeyState { get; set; }
        /// <summary>The URL of the vault.</summary>
        string KeyVaultUrl { get; set; }
        /// <summary>The version of the key.</summary>
        string KeyVersion { get; set; }
        /// <summary>Property of the key if user provided or auto detected</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.EncryptionVersionType? VersionType { get; set; }

    }
}