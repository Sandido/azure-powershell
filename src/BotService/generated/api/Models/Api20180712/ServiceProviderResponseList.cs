namespace Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20180712
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Extensions;

    /// <summary>The list of bot service providers response.</summary>
    public partial class ServiceProviderResponseList :
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20180712.IServiceProviderResponseList,
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20180712.IServiceProviderResponseListInternal
    {

        /// <summary>Internal Acessors for Value</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20180712.IServiceProvider[] Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20180712.IServiceProviderResponseListInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link used to get the next page of bot service providers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20180712.IServiceProvider[] _value;

        /// <summary>Gets the list of bot service providers and their properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20180712.IServiceProvider[] Value { get => this._value; }

        /// <summary>Creates an new <see cref="ServiceProviderResponseList" /> instance.</summary>
        public ServiceProviderResponseList()
        {

        }
    }
    /// The list of bot service providers response.
    public partial interface IServiceProviderResponseList :
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.IJsonSerializable
    {
        /// <summary>The link used to get the next page of bot service providers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The link used to get the next page of bot service providers.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>Gets the list of bot service providers and their properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the list of bot service providers and their properties.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20180712.IServiceProvider) })]
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20180712.IServiceProvider[] Value { get;  }

    }
    /// The list of bot service providers response.
    internal partial interface IServiceProviderResponseListInternal

    {
        /// <summary>The link used to get the next page of bot service providers.</summary>
        string NextLink { get; set; }
        /// <summary>Gets the list of bot service providers and their properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20180712.IServiceProvider[] Value { get; set; }

    }
}