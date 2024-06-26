// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Authorization.Models
{
    using System.Linq;

    /// <summary>
    /// The role management policy rule target.
    /// </summary>
    public partial class RoleManagementPolicyRuleTarget
    {
        /// <summary>
        /// Initializes a new instance of the RoleManagementPolicyRuleTarget class.
        /// </summary>
        public RoleManagementPolicyRuleTarget()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RoleManagementPolicyRuleTarget class.
        /// </summary>

        /// <param name="caller">The caller of the setting.
        /// </param>

        /// <param name="operations">The type of operation.
        /// </param>

        /// <param name="level">The assignment level to which rule is applied.
        /// </param>

        /// <param name="targetObjects">The list of target objects.
        /// </param>

        /// <param name="inheritableSettings">The list of inheritable settings.
        /// </param>

        /// <param name="enforcedSettings">The list of enforced settings.
        /// </param>
        public RoleManagementPolicyRuleTarget(string caller = default(string), System.Collections.Generic.IList<string> operations = default(System.Collections.Generic.IList<string>), string level = default(string), System.Collections.Generic.IList<string> targetObjects = default(System.Collections.Generic.IList<string>), System.Collections.Generic.IList<string> inheritableSettings = default(System.Collections.Generic.IList<string>), System.Collections.Generic.IList<string> enforcedSettings = default(System.Collections.Generic.IList<string>))

        {
            this.Caller = caller;
            this.Operations = operations;
            this.Level = level;
            this.TargetObjects = targetObjects;
            this.InheritableSettings = inheritableSettings;
            this.EnforcedSettings = enforcedSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the caller of the setting.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "caller")]
        public string Caller {get; set; }

        /// <summary>
        /// Gets or sets the type of operation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "operations")]
        public System.Collections.Generic.IList<string> Operations {get; set; }

        /// <summary>
        /// Gets or sets the assignment level to which rule is applied.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "level")]
        public string Level {get; set; }

        /// <summary>
        /// Gets or sets the list of target objects.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "targetObjects")]
        public System.Collections.Generic.IList<string> TargetObjects {get; set; }

        /// <summary>
        /// Gets or sets the list of inheritable settings.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "inheritableSettings")]
        public System.Collections.Generic.IList<string> InheritableSettings {get; set; }

        /// <summary>
        /// Gets or sets the list of enforced settings.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "enforcedSettings")]
        public System.Collections.Generic.IList<string> EnforcedSettings {get; set; }
    }
}