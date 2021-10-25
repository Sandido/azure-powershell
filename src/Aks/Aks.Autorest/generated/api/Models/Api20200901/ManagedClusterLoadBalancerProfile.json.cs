namespace Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20200901
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Extensions;

    /// <summary>Profile of the managed cluster load balancer.</summary>
    public partial class ManagedClusterLoadBalancerProfile
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20200901.IManagedClusterLoadBalancerProfile.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20200901.IManagedClusterLoadBalancerProfile.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20200901.IManagedClusterLoadBalancerProfile FromJson(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject json ? new ManagedClusterLoadBalancerProfile(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject into a new instance of <see cref="ManagedClusterLoadBalancerProfile" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ManagedClusterLoadBalancerProfile(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_managedOutboundIP = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject>("managedOutboundIPs"), out var __jsonManagedOutboundIPs) ? Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20200901.ManagedClusterLoadBalancerProfileManagedOutboundIPs.FromJson(__jsonManagedOutboundIPs) : ManagedOutboundIP;}
            {_outboundIPPrefix = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject>("outboundIPPrefixes"), out var __jsonOutboundIPPrefixes) ? Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20200901.ManagedClusterLoadBalancerProfileOutboundIPPrefixes.FromJson(__jsonOutboundIPPrefixes) : OutboundIPPrefix;}
            {_outboundIP = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject>("outboundIPs"), out var __jsonOutboundIPs) ? Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20200901.ManagedClusterLoadBalancerProfileOutboundIPs.FromJson(__jsonOutboundIPs) : OutboundIP;}
            {_effectiveOutboundIP = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonArray>("effectiveOutboundIPs"), out var __jsonEffectiveOutboundIPs) ? If( __jsonEffectiveOutboundIPs as Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20200901.IResourceReference[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20200901.IResourceReference) (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20200901.ResourceReference.FromJson(__u) )) ))() : null : EffectiveOutboundIP;}
            {_allocatedOutboundPort = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNumber>("allocatedOutboundPorts"), out var __jsonAllocatedOutboundPorts) ? (int?)__jsonAllocatedOutboundPorts : AllocatedOutboundPort;}
            {_idleTimeoutInMinute = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNumber>("idleTimeoutInMinutes"), out var __jsonIdleTimeoutInMinutes) ? (int?)__jsonIdleTimeoutInMinutes : IdleTimeoutInMinute;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="ManagedClusterLoadBalancerProfile" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ManagedClusterLoadBalancerProfile" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._managedOutboundIP ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) this._managedOutboundIP.ToJson(null,serializationMode) : null, "managedOutboundIPs" ,container.Add );
            AddIf( null != this._outboundIPPrefix ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) this._outboundIPPrefix.ToJson(null,serializationMode) : null, "outboundIPPrefixes" ,container.Add );
            AddIf( null != this._outboundIP ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) this._outboundIP.ToJson(null,serializationMode) : null, "outboundIPs" ,container.Add );
            if (null != this._effectiveOutboundIP)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.XNodeArray();
                foreach( var __x in this._effectiveOutboundIP )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("effectiveOutboundIPs",__w);
            }
            AddIf( null != this._allocatedOutboundPort ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNumber((int)this._allocatedOutboundPort) : null, "allocatedOutboundPorts" ,container.Add );
            AddIf( null != this._idleTimeoutInMinute ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNumber((int)this._idleTimeoutInMinute) : null, "idleTimeoutInMinutes" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}