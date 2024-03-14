 

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Commands.Compute.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet(VerbsCommon.Set, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "DiskSecurityProfile", DefaultParameterSetName = "DefaultParameter", SupportsShouldProcess = true)]
    [OutputType(typeof(PSDiskSecurityProfile))]
    public class SetAzureDiskSecurityProfile : ComputeAutomationBaseCmdlet
    {
        [Parameter(
            Position = 0,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        [ResourceGroupCompleter]
        public string ResourceGroupName { get; set; }

        [Parameter(
            Position = 1,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        [Alias("DiskSecurityProfileName")]
        public string Name { get; set; }

        [Parameter(
            Position = 2,
            Mandatory = true,
            ValueFromPipeline = true)]
        [ValidateSet("DiskOn", "VMOn", "SecurityOff")]
        public string GallantSecurity { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }

        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
            ExecuteClientAction(() =>
            {
                if (ShouldProcess(this.Name, VerbsCommon.Set))
                {
                    DiskSecurityProfile diskSecurityProfile = new DiskSecurityProfile();
                    diskSecurityProfile.GallantSecurity = this.GallantSecurity;

                    var result = DiskSecurityProfilesClient.CreateOrUpdate(this.ResourceGroupName, this.Name, diskSecurityProfile);
                    var psObject = new PSDiskSecurityProfile();
                    ComputeAutomationAutoMapperProfile.Mapper.Map<DiskSecurityProfile, PSDiskSecurityProfile>(result, psObject);
                    WriteObject(psObject);
                }
            });
        }
    }
}

