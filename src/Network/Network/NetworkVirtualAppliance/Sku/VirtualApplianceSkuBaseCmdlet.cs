﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------


using Microsoft.Azure.Commands.Network.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.Tags;
using Microsoft.Azure.Management.Network;
using Microsoft.Azure.Management.Network.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
namespace Microsoft.Azure.Commands.Network
{
    public abstract class VirtualApplianceSkuBaseCmdlet : NetworkBaseCmdlet
    {
        public IVirtualApplianceSkusOperations VirtualApplianceSkusClient
        {
            get
            {
                return NetworkClient.NetworkManagementClient.VirtualApplianceSkus;
            }
        }

        public bool IsVirtualApplianceSkuPresent(string name)
        {
            try
            {
                GetVirtualApplianceSku(name);
            }
            catch (Microsoft.Rest.Azure.CloudException exception)
            {
                if (exception.Response.StatusCode == HttpStatusCode.NotFound)
                {
                    // Resource is not present
                    return false;
                }
                throw;
            }
            return true;
        }

        public PSNetworkVirtualApplianceSku GetVirtualApplianceSku(string name)
        {
            var nvaSku = this.VirtualApplianceSkusClient.Get(name);
            var psSku = NetworkResourceManagerProfile.Mapper.Map<PSNetworkVirtualApplianceSku>(nvaSku);
            return psSku;
        }

        public PSNetworkVirtualApplianceSku ToPsNetworkVirtualApplianceSku(NetworkVirtualApplianceSku nvaSku)
        {
            var psSku = NetworkResourceManagerProfile.Mapper.Map<PSNetworkVirtualApplianceSku>(nvaSku);
            return psSku;
        }
    }
}
