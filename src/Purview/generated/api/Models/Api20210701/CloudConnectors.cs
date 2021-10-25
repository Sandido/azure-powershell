namespace Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Extensions;

    public partial class CloudConnectors :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ICloudConnectors,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ICloudConnectorsInternal
    {

        /// <summary>Backing field for <see cref="AwsExternalId" /> property.</summary>
        private string _awsExternalId;

        /// <summary>
        /// AWS external identifier.
        /// Configured in AWS to allow use of the role arn used for scanning
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string AwsExternalId { get => this._awsExternalId; }

        /// <summary>Internal Acessors for AwsExternalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ICloudConnectorsInternal.AwsExternalId { get => this._awsExternalId; set { {_awsExternalId = value;} } }

        /// <summary>Creates an new <see cref="CloudConnectors" /> instance.</summary>
        public CloudConnectors()
        {

        }
    }
    public partial interface ICloudConnectors :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IJsonSerializable
    {
        /// <summary>
        /// AWS external identifier.
        /// Configured in AWS to allow use of the role arn used for scanning
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"AWS external identifier.
        Configured in AWS to allow use of the role arn used for scanning",
        SerializedName = @"awsExternalId",
        PossibleTypes = new [] { typeof(string) })]
        string AwsExternalId { get;  }

    }
    internal partial interface ICloudConnectorsInternal

    {
        /// <summary>
        /// AWS external identifier.
        /// Configured in AWS to allow use of the role arn used for scanning
        /// </summary>
        string AwsExternalId { get; set; }

    }
}