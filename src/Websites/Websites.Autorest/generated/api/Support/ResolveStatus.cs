// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Support
{

    public partial struct ResolveStatus :
        System.IEquatable<ResolveStatus>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ResolveStatus AccessToKeyVaultDenied = @"AccessToKeyVaultDenied";

        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ResolveStatus FetchTimedOut = @"FetchTimedOut";

        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ResolveStatus Initialized = @"Initialized";

        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ResolveStatus InvalidSyntax = @"InvalidSyntax";

        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ResolveStatus MsiNotEnabled = @"MSINotEnabled";

        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ResolveStatus OtherReasons = @"OtherReasons";

        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ResolveStatus Resolved = @"Resolved";

        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ResolveStatus SecretNotFound = @"SecretNotFound";

        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ResolveStatus SecretVersionNotFound = @"SecretVersionNotFound";

        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ResolveStatus UnauthorizedClient = @"UnauthorizedClient";

        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ResolveStatus VaultNotFound = @"VaultNotFound";

        /// <summary>the value for an instance of the <see cref="ResolveStatus" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ResolveStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ResolveStatus" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ResolveStatus(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ResolveStatus</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ResolveStatus e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ResolveStatus (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ResolveStatus && Equals((ResolveStatus)obj);
        }

        /// <summary>Returns hashCode for enum ResolveStatus</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="ResolveStatus" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ResolveStatus(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for ResolveStatus</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ResolveStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ResolveStatus" />.</param>

        public static implicit operator ResolveStatus(string value)
        {
            return new ResolveStatus(value);
        }

        /// <summary>Implicit operator to convert ResolveStatus to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ResolveStatus" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ResolveStatus e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ResolveStatus</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ResolveStatus e1, Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ResolveStatus e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ResolveStatus</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ResolveStatus e1, Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ResolveStatus e2)
        {
            return e2.Equals(e1);
        }
    }
}