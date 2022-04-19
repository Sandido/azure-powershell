#
# Module manifest for module 'Az.Resources'
#
# Generated by: Microsoft Corporation
#
# Generated on: 4/19/2022
#

@{

# Script module or binary module file associated with this manifest.
# RootModule = ''

# Version number of this module.
ModuleVersion = '5.5.0'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = '48bb344d-4c24-441e-8ea0-589947784700'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Microsoft Azure PowerShell - Azure Resource Manager and Active Directory cmdlets in Windows PowerShell and PowerShell Core.  Manages subscriptions, tenants, resource groups, deployment templates, providers, and resource permissions in Azure Resource Manager.  Provides cmdlets for managing resources generically across resource providers.

For more information on Resource Manager, please visit the following: https://docs.microsoft.com/azure/azure-resource-manager/
For more information on Active Directory, please visit the following: https://docs.microsoft.com/azure/active-directory/fundamentals/active-directory-whatis'

# Minimum version of the PowerShell engine required by this module
PowerShellVersion = '5.1'

# Name of the PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.7.2'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# ClrVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @(@{ModuleName = 'Az.Accounts'; ModuleVersion = '2.7.5'; })

# Assemblies that must be loaded prior to importing this module
RequiredAssemblies = 'Microsoft.Azure.Management.Authorization.dll', 
               'Microsoft.Azure.Management.ResourceManager.dll', 
               'Microsoft.Azure.Management.ManagementGroups.dll', 
               'Microsoft.Extensions.Caching.Abstractions.dll', 
               'Microsoft.Extensions.Caching.Memory.dll', 
               'Microsoft.Extensions.DependencyInjection.Abstractions.dll', 
               'Microsoft.Extensions.Options.dll', 
               'Microsoft.Extensions.Primitives.dll', 
               'System.Runtime.CompilerServices.Unsafe.dll', 'AutoMapper.dll', 
               'MSGraph.Autorest\bin\Az.MSGraph.private.dll', 
               'Authorization.Autorest\bin\Az.Authorization.private.dll'

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
FormatsToProcess = 'Resources.format.ps1xml', 'ResourceManager.format.ps1xml', 
               'ResourceManager.generated.format.ps1xml', 'Tags.format.ps1xml', 
               'MSGraph.Autorest\Az.MSGraph.format.ps1xml', 
               'Authorization.Autorest\Az.Authorization.format.ps1xml'

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
NestedModules = @('Microsoft.Azure.PowerShell.Cmdlets.Resources.dll', 
               'Microsoft.Azure.PowerShell.Cmdlets.ResourceManager.dll', 
               'Microsoft.Azure.PowerShell.Cmdlets.Tags.dll', 
               'MSGraph.Autorest\Az.MSGraph.psm1', 
               'Authorization.Autorest\Az.Authorization.psm1')

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = 'Add-AzADAppPermission', 'Add-AzADGroupMember', 
               'Get-AzADAppCredential', 'Get-AzADApplication', 
               'Get-AzADAppPermission', 'Get-AzADGroup', 'Get-AzADGroupMember', 
               'Get-AzADServicePrincipal', 'Get-AzADSpCredential', 'Get-AzADUser', 
               'New-AzADAppCredential', 'New-AzADApplication', 'New-AzADGroup', 
               'New-AzADServicePrincipal', 'New-AzADSpCredential', 'New-AzADUser', 
               'Remove-AzADAppCredential', 'Remove-AzADApplication', 
               'Remove-AzADAppPermission', 'Remove-AzADGroup', 
               'Remove-AzADGroupMember', 'Remove-AzADServicePrincipal', 
               'Remove-AzADSpCredential', 'Remove-AzADUser', 
               'Update-AzADApplication', 'Update-AzADServicePrincipal', 
               'Update-AzADUser', 'Get-AzRoleAssignmentSchedule', 
               'Get-AzRoleAssignmentScheduleInstance', 
               'Get-AzRoleAssignmentScheduleRequest', 
               'Get-AzRoleEligibilitySchedule', 
               'Get-AzRoleEligibilityScheduleInstance', 
               'Get-AzRoleEligibilityScheduleRequest', 
               'Get-AzRoleEligibleChildResource', 'Get-AzRoleManagementPolicy', 
               'Get-AzRoleManagementPolicyAssignment', 
               'New-AzRoleAssignmentScheduleRequest', 
               'New-AzRoleEligibilityScheduleRequest', 
               'New-AzRoleManagementPolicyAssignment', 
               'Remove-AzRoleManagementPolicy', 
               'Remove-AzRoleManagementPolicyAssignment', 
               'Stop-AzRoleAssignmentScheduleRequest', 
               'Stop-AzRoleEligibilityScheduleRequest', 
               'Update-AzRoleManagementPolicy', 'Update-AzADGroup'

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = 'Get-AzProviderOperation', 'Remove-AzRoleAssignment', 
               'Get-AzRoleAssignment', 'New-AzRoleAssignment', 
               'Set-AzRoleAssignment', 'Get-AzRoleDefinition', 
               'New-AzRoleDefinition', 'Set-AzRoleDefinition', 
               'Remove-AzRoleDefinition', 'Remove-AzResourceGroup', 
               'Get-AzProviderFeature', 'Register-AzProviderFeature', 
               'Unregister-AzProviderFeature', 'Get-AzProviderPreviewFeature', 
               'Register-AzProviderPreviewFeature', 
               'Unregister-AzProviderPreviewFeature', 'Get-AzLocation', 
               'Export-AzResourceGroup', 'Get-AzResourceProvider', 
               'Register-AzResourceProvider', 'Unregister-AzResourceProvider', 
               'Get-AzResourceGroupDeployment', 'New-AzResourceGroupDeployment', 
               'Remove-AzResourceGroupDeployment', 
               'Stop-AzResourceGroupDeployment', 'Test-AzResourceGroupDeployment', 
               'Set-AzResourceGroup', 'New-AzResourceGroup', 'Get-AzResourceGroup', 
               'Save-AzResourceGroupDeploymentTemplate', 
               'Get-AzResourceGroupDeploymentOperation', 'Get-AzResourceLock', 
               'Invoke-AzResourceAction', 'Move-AzResource', 'New-AzResourceLock', 
               'Get-AzPolicyAssignment', 'Get-AzPolicyDefinition', 
               'Get-AzPolicySetDefinition', 'Get-AzPolicyExemption', 
               'New-AzPolicyAssignment', 'New-AzPolicyDefinition', 
               'New-AzPolicySetDefinition', 'New-AzPolicyExemption', 
               'Remove-AzPolicyAssignment', 'Remove-AzPolicyDefinition', 
               'Remove-AzPolicySetDefinition', 'Remove-AzPolicyExemption', 
               'Set-AzPolicyAssignment', 'Set-AzPolicyDefinition', 
               'Set-AzPolicySetDefinition', 'Set-AzPolicyExemption', 
               'Remove-AzResource', 'Remove-AzResourceLock', 'Set-AzResource', 
               'New-AzResource', 'Set-AzResourceLock', 'Get-AzResource', 
               'Get-AzManagedApplicationDefinition', 
               'New-AzManagedApplicationDefinition', 
               'Set-AzManagedApplicationDefinition', 
               'Remove-AzManagedApplicationDefinition', 'Get-AzManagedApplication', 
               'New-AzManagedApplication', 'Set-AzManagedApplication', 
               'Remove-AzManagedApplication', 'Get-AzManagementGroup', 
               'New-AzManagementGroup', 'Update-AzManagementGroup', 
               'Remove-AzManagementGroup', 'New-AzManagementGroupSubscription', 
               'Remove-AzManagementGroupSubscription', 'New-AzDeployment', 
               'Get-AzDeployment', 'Test-AzDeployment', 'Remove-AzDeployment', 
               'Stop-AzDeployment', 'Save-AzDeploymentTemplate', 
               'Get-AzDeploymentOperation', 'Get-AzManagementGroupDeployment', 
               'Test-AzManagementGroupDeployment', 
               'New-AzManagementGroupDeployment', 
               'Get-AzManagementGroupDeploymentOperation', 
               'Save-AzManagementGroupDeploymentTemplate', 
               'Stop-AzManagementGroupDeployment', 
               'Remove-AzManagementGroupDeployment', 'Get-AzTenantDeployment', 
               'Test-AzTenantDeployment', 'New-AzTenantDeployment', 
               'Get-AzTenantDeploymentOperation', 
               'Save-AzTenantDeploymentTemplate', 'Stop-AzTenantDeployment', 
               'Remove-AzTenantDeployment', 'Get-AzPolicyAlias', 'Remove-AzTag', 
               'Get-AzTag', 'New-AzTag', 'Get-AzDenyAssignment', 'Update-AzTag', 
               'Get-AzDeploymentScript', 'Get-AzDeploymentScriptLog', 
               'Save-AzDeploymentScriptLog', 'Remove-AzDeploymentScript', 
               'Get-AzDeploymentWhatIfResult', 
               'Get-AzResourceGroupDeploymentWhatIfResult', 
               'Get-AzManagementGroupDeploymentWhatIfResult', 
               'Get-AzTenantDeploymentWhatIfResult', 'Get-AzTemplateSpec', 
               'New-AzTemplateSpec', 'Set-AzTemplateSpec', 'Export-AzTemplateSpec', 
               'Remove-AzTemplateSpec', 'Publish-AzBicepModule', 
               'Get-AzResourceManagementPrivateLink', 
               'Remove-AzResourceManagementPrivateLink', 
               'New-AzResourceManagementPrivateLink', 
               'New-AzPrivateLinkAssociation', 'Get-AzPrivateLinkAssociation', 
               'Remove-AzPrivateLinkAssociation'

# Variables to export from this module
VariablesToExport = '*'

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = 'Get-AzResourceProviderAction', 
               'Get-AzADServicePrincipalCredential', 
               'New-AzADServicePrincipalCredential', 
               'Remove-AzADServicePrincipalCredential', 'Set-AzADApplication', 
               'Set-AzADServicePrincipal', 'Set-AzADUser', 
               'New-AzSubscriptionDeployment', 'Get-AzSubscriptionDeployment', 
               'Test-AzSubscriptionDeployment', 'Remove-AzSubscriptionDeployment', 
               'Stop-AzSubscriptionDeployment', 
               'Save-AzSubscriptionDeploymentTemplate', 
               'Get-AzSubscriptionDeploymentOperation', 
               'Get-AzSubscriptionDeploymentWhatIfResult'

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = 'Azure', 'ResourceManager', 'ARM', 'Provider', 'ResourceGroup', 
               'Deployment', 'ActiveDirectory', 'Authorization', 'Management', 
               'ManagementGroups', 'Tags'

        # A URL to the license for this module.
        LicenseUri = 'https://aka.ms/azps-license'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Azure/azure-powershell'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        ReleaseNotes = '* Removed ''-ApplicationId'' from ''New-AzADServicePrincipal'' ''SimpleParameterSet'' [#17256]
* Added ''New-AzResourceManagementPrivateLink'', and ''New-AzPrivateLinkAssociation'' cmdlets
* Added authorization related cmdlets:
    - ''Get-AzRoleAssignmentSchedule''
    - ''Get-AzRoleAssignmentScheduleInstance''
    - ''Get-AzRoleAssignmentScheduleRequest''
    - ''Get-AzRoleEligibilitySchedule''
    - ''Get-AzRoleEligibilityScheduleInstance''
    - ''Get-AzRoleEligibilityScheduleRequest'' 
    - ''Get-AzRoleEligibleChildResource''
    - ''Get-AzRoleManagementPolicy'' 
    - ''Get-AzRoleManagementPolicyAssignment''
    - ''New-AzRoleAssignmentScheduleRequest'' 
    - ''New-AzRoleEligibilityScheduleRequest''
    - ''New-AzRoleManagementPolicyAssignment'' 
    - ''Remove-AzRoleManagementPolicy''
    - ''Remove-AzRoleManagementPolicyAssignment'' 
    - ''Stop-AzRoleAssignmentScheduleRequest''
    - ''Stop-AzRoleEligibilityScheduleRequest'' 
    - ''Update-AzRoleManagementPolicy''
* Added ''Get-AzResourceManagementPrivateLink'', ''Remove-AzResourceManagementPrivateLink'', ''Get-AzResourceManagementPrivateLinkAssociation'' and  ''Remove-AzResourceManagementPrivateLinkAssociation'' cmdlets'

        # Prerelease string of this module
        # Prerelease = ''

        # Flag to indicate whether the module requires explicit user acceptance for install/update/save
        # RequireLicenseAcceptance = $false

        # External dependent modules of this module
        # ExternalModuleDependencies = @()

    } # End of PSData hashtable

} # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

