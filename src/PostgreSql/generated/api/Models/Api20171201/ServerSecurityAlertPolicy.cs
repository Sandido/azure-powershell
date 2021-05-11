namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Extensions;

    /// <summary>A server security alert policy.</summary>
    public partial class ServerSecurityAlertPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerSecurityAlertPolicy,
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerSecurityAlertPolicyInternal,
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.Resource();

        /// <summary>
        /// Specifies an array of alerts that are disabled. Allowed values are: Sql_Injection, Sql_Injection_Vulnerability, Access_Anomaly
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public string[] DisabledAlert { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.ISecurityAlertPolicyPropertiesInternal)Property).DisabledAlert; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.ISecurityAlertPolicyPropertiesInternal)Property).DisabledAlert = value ?? null /* arrayOf */; }

        /// <summary>Specifies that the alert is sent to the account administrators.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public bool? EmailAccountAdmin { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.ISecurityAlertPolicyPropertiesInternal)Property).EmailAccountAdmin; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.ISecurityAlertPolicyPropertiesInternal)Property).EmailAccountAdmin = value ?? default(bool); }

        /// <summary>Specifies an array of e-mail addresses to which the alert is sent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public string[] EmailAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.ISecurityAlertPolicyPropertiesInternal)Property).EmailAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.ISecurityAlertPolicyPropertiesInternal)Property).EmailAddress = value ?? null /* arrayOf */; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal)__resource).Id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.ISecurityAlertPolicyProperties Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerSecurityAlertPolicyInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.SecurityAlertPolicyProperties()); set { {_property = value;} } }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.ISecurityAlertPolicyProperties _property;

        /// <summary>Resource properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.ISecurityAlertPolicyProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.SecurityAlertPolicyProperties()); set => this._property = value; }

        /// <summary>Specifies the number of days to keep in the Threat Detection audit logs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public int? RetentionDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.ISecurityAlertPolicyPropertiesInternal)Property).RetentionDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.ISecurityAlertPolicyPropertiesInternal)Property).RetentionDay = value ?? default(int); }

        /// <summary>Specifies the state of the policy, whether it is enabled or disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerSecurityAlertPolicyState? State { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.ISecurityAlertPolicyPropertiesInternal)Property).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.ISecurityAlertPolicyPropertiesInternal)Property).State = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerSecurityAlertPolicyState)""); }

        /// <summary>Specifies the identifier key of the Threat Detection audit storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public string StorageAccountAccessKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.ISecurityAlertPolicyPropertiesInternal)Property).StorageAccountAccessKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.ISecurityAlertPolicyPropertiesInternal)Property).StorageAccountAccessKey = value ?? null; }

        /// <summary>
        /// Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). This blob storage will hold all Threat
        /// Detection audit logs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public string StorageEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.ISecurityAlertPolicyPropertiesInternal)Property).StorageEndpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.ISecurityAlertPolicyPropertiesInternal)Property).StorageEndpoint = value ?? null; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="ServerSecurityAlertPolicy" /> instance.</summary>
        public ServerSecurityAlertPolicy()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// A server security alert policy.
    public partial interface IServerSecurityAlertPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResource
    {
        /// <summary>
        /// Specifies an array of alerts that are disabled. Allowed values are: Sql_Injection, Sql_Injection_Vulnerability, Access_Anomaly
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies an array of alerts that are disabled. Allowed values are: Sql_Injection, Sql_Injection_Vulnerability, Access_Anomaly",
        SerializedName = @"disabledAlerts",
        PossibleTypes = new [] { typeof(string) })]
        string[] DisabledAlert { get; set; }
        /// <summary>Specifies that the alert is sent to the account administrators.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies that the alert is sent to the account administrators.",
        SerializedName = @"emailAccountAdmins",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EmailAccountAdmin { get; set; }
        /// <summary>Specifies an array of e-mail addresses to which the alert is sent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies an array of e-mail addresses to which the alert is sent.",
        SerializedName = @"emailAddresses",
        PossibleTypes = new [] { typeof(string) })]
        string[] EmailAddress { get; set; }
        /// <summary>Specifies the number of days to keep in the Threat Detection audit logs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the number of days to keep in the Threat Detection audit logs.",
        SerializedName = @"retentionDays",
        PossibleTypes = new [] { typeof(int) })]
        int? RetentionDay { get; set; }
        /// <summary>Specifies the state of the policy, whether it is enabled or disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the state of the policy, whether it is enabled or disabled.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerSecurityAlertPolicyState) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerSecurityAlertPolicyState? State { get; set; }
        /// <summary>Specifies the identifier key of the Threat Detection audit storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the identifier key of the Threat Detection audit storage account.",
        SerializedName = @"storageAccountAccessKey",
        PossibleTypes = new [] { typeof(string) })]
        string StorageAccountAccessKey { get; set; }
        /// <summary>
        /// Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). This blob storage will hold all Threat
        /// Detection audit logs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). This blob storage will hold all Threat Detection audit logs.",
        SerializedName = @"storageEndpoint",
        PossibleTypes = new [] { typeof(string) })]
        string StorageEndpoint { get; set; }

    }
    /// A server security alert policy.
    internal partial interface IServerSecurityAlertPolicyInternal :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal
    {
        /// <summary>
        /// Specifies an array of alerts that are disabled. Allowed values are: Sql_Injection, Sql_Injection_Vulnerability, Access_Anomaly
        /// </summary>
        string[] DisabledAlert { get; set; }
        /// <summary>Specifies that the alert is sent to the account administrators.</summary>
        bool? EmailAccountAdmin { get; set; }
        /// <summary>Specifies an array of e-mail addresses to which the alert is sent.</summary>
        string[] EmailAddress { get; set; }
        /// <summary>Resource properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.ISecurityAlertPolicyProperties Property { get; set; }
        /// <summary>Specifies the number of days to keep in the Threat Detection audit logs.</summary>
        int? RetentionDay { get; set; }
        /// <summary>Specifies the state of the policy, whether it is enabled or disabled.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerSecurityAlertPolicyState? State { get; set; }
        /// <summary>Specifies the identifier key of the Threat Detection audit storage account.</summary>
        string StorageAccountAccessKey { get; set; }
        /// <summary>
        /// Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). This blob storage will hold all Threat
        /// Detection audit logs.
        /// </summary>
        string StorageEndpoint { get; set; }

    }
}