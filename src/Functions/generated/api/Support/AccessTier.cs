// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Support
{

    /// <summary>
    /// Required for storage accounts where kind = BlobStorage. The access tier used for billing.
    /// </summary>
    public partial struct AccessTier :
        System.IEquatable<AccessTier>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AccessTier Cool = @"Cool";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AccessTier Hot = @"Hot";

        /// <summary>the value for an instance of the <see cref="AccessTier" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="AccessTier" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private AccessTier(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to AccessTier</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AccessTier" />.</param>
        internal static object CreateFrom(object value)
        {
            return new AccessTier(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type AccessTier</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AccessTier e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type AccessTier (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is AccessTier && Equals((AccessTier)obj);
        }

        /// <summary>Returns hashCode for enum AccessTier</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for AccessTier</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to AccessTier</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AccessTier" />.</param>

        public static implicit operator AccessTier(string value)
        {
            return new AccessTier(value);
        }

        /// <summary>Implicit operator to convert AccessTier to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="AccessTier" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AccessTier e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum AccessTier</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AccessTier e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AccessTier e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum AccessTier</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AccessTier e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AccessTier e2)
        {
            return e2.Equals(e1);
        }
    }
}