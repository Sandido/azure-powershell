namespace Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Extensions;

    /// <summary>Defines the move resource properties.</summary>
    public partial class MoveResourceProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonObject json ? new MoveResourceProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonObject into a new instance of <see cref="MoveResourceProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal MoveResourceProperties(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_error = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonObject>("errors"), out var __jsonErrors) ? Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.MoveResourcePropertiesErrors.FromJson(__jsonErrors) : Error;}
            {_moveStatus = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonObject>("moveStatus"), out var __jsonMoveStatus) ? Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.MoveResourcePropertiesMoveStatus.FromJson(__jsonMoveStatus) : MoveStatus;}
            {_resourceSetting = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonObject>("resourceSettings"), out var __jsonResourceSettings) ? Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.ResourceSettings.FromJson(__jsonResourceSettings) : ResourceSetting;}
            {_sourceResourceSetting = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonObject>("sourceResourceSettings"), out var __jsonSourceResourceSettings) ? Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.MoveResourcePropertiesSourceResourceSettings.FromJson(__jsonSourceResourceSettings) : SourceResourceSetting;}
            {_dependsOn = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonArray>("dependsOn"), out var __jsonDependsOn) ? If( __jsonDependsOn as Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceDependency[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceDependency) (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.MoveResourceDependency.FromJson(__u) )) ))() : null : DependsOn;}
            {_dependsOnOverride = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonArray>("dependsOnOverrides"), out var __jsonDependsOnOverrides) ? If( __jsonDependsOnOverrides as Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceDependencyOverride[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceDependencyOverride) (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.MoveResourceDependencyOverride.FromJson(__p) )) ))() : null : DependsOnOverride;}
            {_existingTargetId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonString>("existingTargetId"), out var __jsonExistingTargetId) ? (string)__jsonExistingTargetId : (string)ExistingTargetId;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)ProvisioningState;}
            {_sourceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonString>("sourceId"), out var __jsonSourceId) ? (string)__jsonSourceId : (string)SourceId;}
            {_targetId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonString>("targetId"), out var __jsonTargetId) ? (string)__jsonTargetId : (string)TargetId;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="MoveResourceProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MoveResourceProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._error ? (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonNode) this._error.ToJson(null,serializationMode) : null, "errors" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._moveStatus ? (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonNode) this._moveStatus.ToJson(null,serializationMode) : null, "moveStatus" ,container.Add );
            }
            AddIf( null != this._resourceSetting ? (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonNode) this._resourceSetting.ToJson(null,serializationMode) : null, "resourceSettings" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._sourceResourceSetting ? (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonNode) this._sourceResourceSetting.ToJson(null,serializationMode) : null, "sourceResourceSettings" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.SerializationMode.IncludeReadOnly))
            {
                if (null != this._dependsOn)
                {
                    var __w = new Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.XNodeArray();
                    foreach( var __x in this._dependsOn )
                    {
                        AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                    }
                    container.Add("dependsOn",__w);
                }
            }
            if (null != this._dependsOnOverride)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.XNodeArray();
                foreach( var __s in this._dependsOnOverride )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("dependsOnOverrides",__r);
            }
            AddIf( null != (((object)this._existingTargetId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonString(this._existingTargetId.ToString()) : null, "existingTargetId" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            AddIf( null != (((object)this._sourceId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonString(this._sourceId.ToString()) : null, "sourceId" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._targetId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonString(this._targetId.ToString()) : null, "targetId" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}