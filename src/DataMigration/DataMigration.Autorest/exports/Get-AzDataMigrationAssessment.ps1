
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Start assessment on SQL Server instance(s)
.Description
Start assessment on SQL Server instance(s)
.Example
PS C:\> Get-AzDataMigrationAssessment -ConnectionString "Data Source=LabServer.database.net;Initial Catalog=master;Integrated Security=False;User Id=User;Password=password" -OutputFolder "C:\AssessmentOutput" -Overwrite

Starting SQL assessment...
Progress: 100%; Issues Found: 100; Objects Assessed: 500/500; Status: Completed; Total time: 00:01:50.000.

Finishing SQL assessment...
Assessment report saved to C:\Users\user\AppData\Local\Microsoft\SqlAssessment\SqlAssessmentReport.json.
Event and Error Logs Folder Path: C:\Users\user\AppData\Local\Microsoft\SqlAssessment\Logs
.Example
PS C:\> Get-AzDataMigrationAssessment -ConfigFilePath "C:\Users\user\document\config.json"

Starting SQL assessment...
Progress: 100%; Issues Found: 100; Objects Assessed: 550/550; Status: Completed; Total time: 00:01:50.000.

Finishing SQL assessment...
Assessment report saved to C:\Users\user\AppData\Local\Microsoft\SqlAssessment\SqlAssessmentReport.json.
Event and Error Logs Folder Path: C:\Users\user\AppData\Local\Microsoft\SqlAssessment\Logs

.Outputs
System.Boolean
.Link
https://docs.microsoft.com/powershell/module/az.datamigration/get-azdatamigrationassessment
#>
function Get-AzDataMigrationAssessment {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='CommandLine', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='CommandLine', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Body')]
    [System.String[]]
    # Sql Server Connection Strings
    ${ConnectionString},

    [Parameter(ParameterSetName='CommandLine')]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Body')]
    [System.String]
    # Output folder to store assessment report
    ${OutputFolder},

    [Parameter(ParameterSetName='CommandLine')]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Enable this parameter to overwrite the existing assessment report
    ${Overwrite},

    [Parameter(ParameterSetName='ConfigFile', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Body')]
    [System.String]
    # Path of the ConfigFile
    ${ConfigFilePath},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    ${PassThru}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            CommandLine = 'Az.DataMigration.custom\Get-AzDataMigrationAssessment';
            ConfigFile = 'Az.DataMigration.custom\Get-AzDataMigrationAssessment';
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
