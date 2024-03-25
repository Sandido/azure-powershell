 

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.Azure.Management.Compute.Models;

namespace Microsoft.Azure.Commands.Compute.Automation.Models
{
    public partial class PSDisk
    {
        public string ResourceGroupName
        {
            get
            {
                if (string.IsNullOrEmpty(Id)) return null;
                Regex r = new Regex(@"(.*?)/resourcegroups/(?<rgname>\S+)/providers/(.*?)", RegexOptions.IgnoreCase);
                Match m = r.Match(Id);
                return m.Success ? m.Groups["rgname"].Value : null;
            }
        }

        public string ManagedBy { get; set; }
        public IList<string> ManagedByExtended { get; set; }
        public DiskSku Sku { get; set; }
        public IList<string> Zones { get; set; }
        public DateTime? TimeCreated { get; set; }
        public OperatingSystemTypes? OsType { get; set; }
        public string HyperVGeneration { get; set; }
        public CreationData CreationData { get; set; }
        public int? DiskSizeGB { get; set; }
        public long? DiskSizeBytes { get; set; }
        public string UniqueId { get; set; }
        public EncryptionSettingsCollection EncryptionSettingsCollection { get; set; }
        public string ProvisioningState { get; set; }
        public long? DiskIOPSReadWrite { get; set; }
        public long? DiskMBpsReadWrite { get; set; }
        public long? DiskIOPSReadOnly { get; set; }
        public long? DiskMBpsReadOnly { get; set; }
        public string DiskState { get; set; }
        public Encryption Encryption { get; set; }
        public int? MaxShares { get; set; }
        public IList<ShareInfoElement> ShareInfo { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public ExtendedLocation ExtendedLocation { get; set; }
        public IDictionary<string, string> Tags { get; set; }
        public string NetworkAccessPolicy { get; set; }
        public string DiskAccessId { get; set; }
        public string Tier { get; set; }
        public bool? BurstingEnabled { get; set; }
        public PSPurchasePlan PurchasePlan { get; set; }
        public bool? SupportsHibernation { get; set; }
        public DiskSecurityProfile SecurityProfile { get; set; } = null;
        public string PublicNetworkAccess { get; set; }
        public SupportedCapabilities SupportedCapabilities { get; set; }
        public string DataAccessAuthMode { get; set; }
        public double? CompletionPercent { get; set; }
        public bool? OptimizedForFrequentAttach { get; set; }
    }
}