namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Extensions;

    /// <summary>The properties of a server.</summary>
    public partial class ServerPropertiesAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGenerated,
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal
    {

        /// <summary>Backing field for <see cref="AdministratorLogin" /> property.</summary>
        private string _administratorLogin;

        /// <summary>
        /// The administrator's login name of a server. Can only be specified when the server is being created (and is required for
        /// creation).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string AdministratorLogin { get => this._administratorLogin; set => this._administratorLogin = value; }

        /// <summary>Backing field for <see cref="AdministratorLoginPassword" /> property.</summary>
        private System.Security.SecureString _administratorLoginPassword;

        /// <summary>The administrator login password (required for server creation).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public System.Security.SecureString AdministratorLoginPassword { get => this._administratorLoginPassword; set => this._administratorLoginPassword = value; }

        /// <summary>Backing field for <see cref="AvailabilityZone" /> property.</summary>
        private string _availabilityZone;

        /// <summary>availability Zone information of the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string AvailabilityZone { get => this._availabilityZone; set => this._availabilityZone = value; }

        /// <summary>Backing field for <see cref="ByokEnforcement" /> property.</summary>
        private string _byokEnforcement;

        /// <summary>
        /// Status showing whether the data encryption is enabled with customer-managed keys.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string ByokEnforcement { get => this._byokEnforcement; }

        /// <summary>Backing field for <see cref="CreateMode" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.CreateMode? _createMode;

        /// <summary>The mode to create a new PostgreSQL server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.CreateMode? CreateMode { get => this._createMode; set => this._createMode = value; }

        /// <summary>Backing field for <see cref="DelegatedSubnetArgument" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesDelegatedSubnetArguments _delegatedSubnetArgument;

        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesDelegatedSubnetArguments DelegatedSubnetArgument { get => (this._delegatedSubnetArgument = this._delegatedSubnetArgument ?? new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.ServerPropertiesDelegatedSubnetArguments()); set => this._delegatedSubnetArgument = value; }

        /// <summary>delegated subnet arm resource id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public string DelegatedSubnetArgumentSubnetArmResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesDelegatedSubnetArgumentsInternal)DelegatedSubnetArgument).SubnetArmResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesDelegatedSubnetArgumentsInternal)DelegatedSubnetArgument).SubnetArmResourceId = value ?? null; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>The display name of a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="FullyQualifiedDomainName" /> property.</summary>
        private string _fullyQualifiedDomainName;

        /// <summary>The fully qualified domain name of a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string FullyQualifiedDomainName { get => this._fullyQualifiedDomainName; }

        /// <summary>Backing field for <see cref="HaEnabled" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HaEnabledEnum? _haEnabled;

        /// <summary>stand by count value can be either enabled or disabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HaEnabledEnum? HaEnabled { get => this._haEnabled; set => this._haEnabled = value; }

        /// <summary>Backing field for <see cref="HaState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerHaState? _haState;

        /// <summary>A state of a HA server that is visible to user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerHaState? HaState { get => this._haState; }

        /// <summary>Backing field for <see cref="MaintenanceWindow" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IMaintenanceWindow _maintenanceWindow;

        /// <summary>Maintenance window of a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IMaintenanceWindow MaintenanceWindow { get => (this._maintenanceWindow = this._maintenanceWindow ?? new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.MaintenanceWindow()); set => this._maintenanceWindow = value; }

        /// <summary>indicates whether custom window is enabled or disabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public string MaintenanceWindowCustomWindow { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IMaintenanceWindowInternal)MaintenanceWindow).CustomWindow; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IMaintenanceWindowInternal)MaintenanceWindow).CustomWindow = value ?? null; }

        /// <summary>day of week for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public int? MaintenanceWindowDayOfWeek { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IMaintenanceWindowInternal)MaintenanceWindow).DayOfWeek; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IMaintenanceWindowInternal)MaintenanceWindow).DayOfWeek = value ?? default(int); }

        /// <summary>start hour for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public int? MaintenanceWindowStartHour { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IMaintenanceWindowInternal)MaintenanceWindow).StartHour; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IMaintenanceWindowInternal)MaintenanceWindow).StartHour = value ?? default(int); }

        /// <summary>start minute for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public int? MaintenanceWindowStartMinute { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IMaintenanceWindowInternal)MaintenanceWindow).StartMinute; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IMaintenanceWindowInternal)MaintenanceWindow).StartMinute = value ?? default(int); }

        /// <summary>Internal Acessors for ByokEnforcement</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal.ByokEnforcement { get => this._byokEnforcement; set { {_byokEnforcement = value;} } }

        /// <summary>Internal Acessors for DelegatedSubnetArgument</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesDelegatedSubnetArguments Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal.DelegatedSubnetArgument { get => (this._delegatedSubnetArgument = this._delegatedSubnetArgument ?? new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.ServerPropertiesDelegatedSubnetArguments()); set { {_delegatedSubnetArgument = value;} } }

        /// <summary>Internal Acessors for FullyQualifiedDomainName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal.FullyQualifiedDomainName { get => this._fullyQualifiedDomainName; set { {_fullyQualifiedDomainName = value;} } }

        /// <summary>Internal Acessors for HaState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerHaState? Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal.HaState { get => this._haState; set { {_haState = value;} } }

        /// <summary>Internal Acessors for MaintenanceWindow</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IMaintenanceWindow Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal.MaintenanceWindow { get => (this._maintenanceWindow = this._maintenanceWindow ?? new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.MaintenanceWindow()); set { {_maintenanceWindow = value;} } }

        /// <summary>Internal Acessors for PublicNetworkAccess</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerPublicNetworkAccessState? Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal.PublicNetworkAccess { get => this._publicNetworkAccess; set { {_publicNetworkAccess = value;} } }

        /// <summary>Internal Acessors for StandbyAvailabilityZone</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal.StandbyAvailabilityZone { get => this._standbyAvailabilityZone; set { {_standbyAvailabilityZone = value;} } }

        /// <summary>Internal Acessors for State</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerState? Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal.State { get => this._state; set { {_state = value;} } }

        /// <summary>Internal Acessors for StorageProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IStorageProfileAutoGenerated Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesAutoGeneratedInternal.StorageProfile { get => (this._storageProfile = this._storageProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.StorageProfileAutoGenerated()); set { {_storageProfile = value;} } }

        /// <summary>Backing field for <see cref="PointInTimeUtc" /> property.</summary>
        private global::System.DateTime? _pointInTimeUtc;

        /// <summary>
        /// Restore point creation time (ISO8601 format), specifying the time to restore from.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public global::System.DateTime? PointInTimeUtc { get => this._pointInTimeUtc; set => this._pointInTimeUtc = value; }

        /// <summary>Backing field for <see cref="PublicNetworkAccess" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerPublicNetworkAccessState? _publicNetworkAccess;

        /// <summary>public network access is enabled or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerPublicNetworkAccessState? PublicNetworkAccess { get => this._publicNetworkAccess; }

        /// <summary>Backing field for <see cref="SourceServerName" /> property.</summary>
        private string _sourceServerName;

        /// <summary>The source PostgreSQL server name to restore from.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string SourceServerName { get => this._sourceServerName; set => this._sourceServerName = value; }

        /// <summary>Backing field for <see cref="StandbyAvailabilityZone" /> property.</summary>
        private string _standbyAvailabilityZone;

        /// <summary>availability Zone information of the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string StandbyAvailabilityZone { get => this._standbyAvailabilityZone; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerState? _state;

        /// <summary>A state of a server that is visible to user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerState? State { get => this._state; }

        /// <summary>Backing field for <see cref="StorageProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IStorageProfileAutoGenerated _storageProfile;

        /// <summary>Storage profile of a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IStorageProfileAutoGenerated StorageProfile { get => (this._storageProfile = this._storageProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.StorageProfileAutoGenerated()); set => this._storageProfile = value; }

        /// <summary>Backup retention days for the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public int? StorageProfileBackupRetentionDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IStorageProfileAutoGeneratedInternal)StorageProfile).BackupRetentionDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IStorageProfileAutoGeneratedInternal)StorageProfile).BackupRetentionDay = value ?? default(int); }

        /// <summary>Max storage allowed for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public int? StorageProfileStorageMb { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IStorageProfileAutoGeneratedInternal)StorageProfile).StorageMb; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IStorageProfileAutoGeneratedInternal)StorageProfile).StorageMb = value ?? default(int); }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesTags _tag;

        /// <summary>Application-specific metadata in the form of key-value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.ServerPropertiesTags()); set => this._tag = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerVersion? _version;

        /// <summary>PostgreSQL Server version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerVersion? Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="ServerPropertiesAutoGenerated" /> instance.</summary>
        public ServerPropertiesAutoGenerated()
        {

        }
    }
    /// The properties of a server.
    public partial interface IServerPropertiesAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The administrator's login name of a server. Can only be specified when the server is being created (and is required for
        /// creation).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The administrator's login name of a server. Can only be specified when the server is being created (and is required for creation).",
        SerializedName = @"administratorLogin",
        PossibleTypes = new [] { typeof(string) })]
        string AdministratorLogin { get; set; }
        /// <summary>The administrator login password (required for server creation).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The administrator login password (required for server creation).",
        SerializedName = @"administratorLoginPassword",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString AdministratorLoginPassword { get; set; }
        /// <summary>availability Zone information of the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"availability Zone information of the server.",
        SerializedName = @"availabilityZone",
        PossibleTypes = new [] { typeof(string) })]
        string AvailabilityZone { get; set; }
        /// <summary>
        /// Status showing whether the data encryption is enabled with customer-managed keys.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Status showing whether the data encryption is enabled with customer-managed keys.",
        SerializedName = @"byokEnforcement",
        PossibleTypes = new [] { typeof(string) })]
        string ByokEnforcement { get;  }
        /// <summary>The mode to create a new PostgreSQL server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The mode to create a new PostgreSQL server.",
        SerializedName = @"createMode",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.CreateMode) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.CreateMode? CreateMode { get; set; }
        /// <summary>delegated subnet arm resource id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"delegated subnet arm resource id.",
        SerializedName = @"subnetArmResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string DelegatedSubnetArgumentSubnetArmResourceId { get; set; }
        /// <summary>The display name of a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The display name of a server.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>The fully qualified domain name of a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The fully qualified domain name of a server.",
        SerializedName = @"fullyQualifiedDomainName",
        PossibleTypes = new [] { typeof(string) })]
        string FullyQualifiedDomainName { get;  }
        /// <summary>stand by count value can be either enabled or disabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"stand by count value can be either enabled or disabled",
        SerializedName = @"haEnabled",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HaEnabledEnum) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HaEnabledEnum? HaEnabled { get; set; }
        /// <summary>A state of a HA server that is visible to user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A state of a HA server that is visible to user.",
        SerializedName = @"haState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerHaState) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerHaState? HaState { get;  }
        /// <summary>indicates whether custom window is enabled or disabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"indicates whether custom window is enabled or disabled",
        SerializedName = @"customWindow",
        PossibleTypes = new [] { typeof(string) })]
        string MaintenanceWindowCustomWindow { get; set; }
        /// <summary>day of week for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"day of week for maintenance window",
        SerializedName = @"dayOfWeek",
        PossibleTypes = new [] { typeof(int) })]
        int? MaintenanceWindowDayOfWeek { get; set; }
        /// <summary>start hour for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"start hour for maintenance window",
        SerializedName = @"startHour",
        PossibleTypes = new [] { typeof(int) })]
        int? MaintenanceWindowStartHour { get; set; }
        /// <summary>start minute for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"start minute for maintenance window",
        SerializedName = @"startMinute",
        PossibleTypes = new [] { typeof(int) })]
        int? MaintenanceWindowStartMinute { get; set; }
        /// <summary>
        /// Restore point creation time (ISO8601 format), specifying the time to restore from.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Restore point creation time (ISO8601 format), specifying the time to restore from.",
        SerializedName = @"pointInTimeUTC",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? PointInTimeUtc { get; set; }
        /// <summary>public network access is enabled or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"public network access is enabled or not",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerPublicNetworkAccessState) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerPublicNetworkAccessState? PublicNetworkAccess { get;  }
        /// <summary>The source PostgreSQL server name to restore from.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The source PostgreSQL server name to restore from.",
        SerializedName = @"sourceServerName",
        PossibleTypes = new [] { typeof(string) })]
        string SourceServerName { get; set; }
        /// <summary>availability Zone information of the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"availability Zone information of the server.",
        SerializedName = @"standbyAvailabilityZone",
        PossibleTypes = new [] { typeof(string) })]
        string StandbyAvailabilityZone { get;  }
        /// <summary>A state of a server that is visible to user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A state of a server that is visible to user.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerState) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerState? State { get;  }
        /// <summary>Backup retention days for the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Backup retention days for the server.",
        SerializedName = @"backupRetentionDays",
        PossibleTypes = new [] { typeof(int) })]
        int? StorageProfileBackupRetentionDay { get; set; }
        /// <summary>Max storage allowed for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Max storage allowed for a server.",
        SerializedName = @"storageMB",
        PossibleTypes = new [] { typeof(int) })]
        int? StorageProfileStorageMb { get; set; }
        /// <summary>Application-specific metadata in the form of key-value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Application-specific metadata in the form of key-value pairs.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesTags Tag { get; set; }
        /// <summary>PostgreSQL Server version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"PostgreSQL Server version.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerVersion) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerVersion? Version { get; set; }

    }
    /// The properties of a server.
    internal partial interface IServerPropertiesAutoGeneratedInternal

    {
        /// <summary>
        /// The administrator's login name of a server. Can only be specified when the server is being created (and is required for
        /// creation).
        /// </summary>
        string AdministratorLogin { get; set; }
        /// <summary>The administrator login password (required for server creation).</summary>
        System.Security.SecureString AdministratorLoginPassword { get; set; }
        /// <summary>availability Zone information of the server.</summary>
        string AvailabilityZone { get; set; }
        /// <summary>
        /// Status showing whether the data encryption is enabled with customer-managed keys.
        /// </summary>
        string ByokEnforcement { get; set; }
        /// <summary>The mode to create a new PostgreSQL server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.CreateMode? CreateMode { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesDelegatedSubnetArguments DelegatedSubnetArgument { get; set; }
        /// <summary>delegated subnet arm resource id.</summary>
        string DelegatedSubnetArgumentSubnetArmResourceId { get; set; }
        /// <summary>The display name of a server.</summary>
        string DisplayName { get; set; }
        /// <summary>The fully qualified domain name of a server.</summary>
        string FullyQualifiedDomainName { get; set; }
        /// <summary>stand by count value can be either enabled or disabled</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HaEnabledEnum? HaEnabled { get; set; }
        /// <summary>A state of a HA server that is visible to user.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerHaState? HaState { get; set; }
        /// <summary>Maintenance window of a server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IMaintenanceWindow MaintenanceWindow { get; set; }
        /// <summary>indicates whether custom window is enabled or disabled</summary>
        string MaintenanceWindowCustomWindow { get; set; }
        /// <summary>day of week for maintenance window</summary>
        int? MaintenanceWindowDayOfWeek { get; set; }
        /// <summary>start hour for maintenance window</summary>
        int? MaintenanceWindowStartHour { get; set; }
        /// <summary>start minute for maintenance window</summary>
        int? MaintenanceWindowStartMinute { get; set; }
        /// <summary>
        /// Restore point creation time (ISO8601 format), specifying the time to restore from.
        /// </summary>
        global::System.DateTime? PointInTimeUtc { get; set; }
        /// <summary>public network access is enabled or not</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerPublicNetworkAccessState? PublicNetworkAccess { get; set; }
        /// <summary>The source PostgreSQL server name to restore from.</summary>
        string SourceServerName { get; set; }
        /// <summary>availability Zone information of the server.</summary>
        string StandbyAvailabilityZone { get; set; }
        /// <summary>A state of a server that is visible to user.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerState? State { get; set; }
        /// <summary>Storage profile of a server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IStorageProfileAutoGenerated StorageProfile { get; set; }
        /// <summary>Backup retention days for the server.</summary>
        int? StorageProfileBackupRetentionDay { get; set; }
        /// <summary>Max storage allowed for a server.</summary>
        int? StorageProfileStorageMb { get; set; }
        /// <summary>Application-specific metadata in the form of key-value pairs.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesTags Tag { get; set; }
        /// <summary>PostgreSQL Server version.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerVersion? Version { get; set; }

    }
}