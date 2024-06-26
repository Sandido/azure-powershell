// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// Trigger that creates pipeline runs periodically, on schedule.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ScheduleTrigger")]
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ScheduleTrigger : MultiplePipelineTrigger
    {
        /// <summary>
        /// Initializes a new instance of the ScheduleTrigger class.
        /// </summary>
        public ScheduleTrigger()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScheduleTrigger class.
        /// </summary>

        /// <param name="additionalProperties">Azure data factory nested object which contains information about creating
        /// pipeline run
        /// </param>

        /// <param name="description">Trigger description.
        /// </param>

        /// <param name="runtimeState">Indicates if trigger is running or not. Updated when Start/Stop APIs are
        /// called on the Trigger.
        /// Possible values include: &#39;Started&#39;, &#39;Stopped&#39;, &#39;Disabled&#39;</param>

        /// <param name="annotations">List of tags that can be used for describing the trigger.
        /// </param>

        /// <param name="pipelines">Pipelines that need to be started.
        /// </param>

        /// <param name="recurrence">Recurrence schedule configuration.
        /// </param>
        public ScheduleTrigger(ScheduleTriggerRecurrence recurrence, System.Collections.Generic.IDictionary<string, object> additionalProperties = default(System.Collections.Generic.IDictionary<string, object>), string description = default(string), string runtimeState = default(string), System.Collections.Generic.IList<object> annotations = default(System.Collections.Generic.IList<object>), System.Collections.Generic.IList<TriggerPipelineReference> pipelines = default(System.Collections.Generic.IList<TriggerPipelineReference>))

        : base(additionalProperties, description, runtimeState, annotations, pipelines)
        {
            this.Recurrence = recurrence;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets recurrence schedule configuration.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.recurrence")]
        public ScheduleTriggerRecurrence Recurrence {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Recurrence == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Recurrence");
            }

        }
    }
}