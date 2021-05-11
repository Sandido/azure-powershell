// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support
{

    /// <summary>Sets the frequency at which a snapshot of the database is created.</summary>
    public partial struct RdbFrequency :
        System.IEquatable<RdbFrequency>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.RdbFrequency OneH = @"1h";

        public static Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.RdbFrequency SixH = @"6h";

        public static Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.RdbFrequency TwelveH = @"12h";

        /// <summary>the value for an instance of the <see cref="RdbFrequency" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to RdbFrequency</summary>
        /// <param name="value">the value to convert to an instance of <see cref="RdbFrequency" />.</param>
        internal static object CreateFrom(object value)
        {
            return new RdbFrequency(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type RdbFrequency</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.RdbFrequency e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type RdbFrequency (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is RdbFrequency && Equals((RdbFrequency)obj);
        }

        /// <summary>Returns hashCode for enum RdbFrequency</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="RdbFrequency" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private RdbFrequency(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for RdbFrequency</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to RdbFrequency</summary>
        /// <param name="value">the value to convert to an instance of <see cref="RdbFrequency" />.</param>

        public static implicit operator RdbFrequency(string value)
        {
            return new RdbFrequency(value);
        }

        /// <summary>Implicit operator to convert RdbFrequency to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="RdbFrequency" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.RdbFrequency e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum RdbFrequency</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.RdbFrequency e1, Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.RdbFrequency e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum RdbFrequency</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.RdbFrequency e1, Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.RdbFrequency e2)
        {
            return e2.Equals(e1);
        }
    }
}