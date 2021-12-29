// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support
{

    /// <summary>Name of the stage which is in progress.</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageNameTypeConverter))]
    public partial struct StageName :
        System.Management.Automation.IArgumentCompleter
    {

        /// <summary>
        /// Implementations of this function are called by PowerShell to complete arguments.
        /// </summary>
        /// <param name="commandName">The name of the command that needs argument completion.</param>
        /// <param name="parameterName">The name of the parameter that needs argument completion.</param>
        /// <param name="wordToComplete">The (possibly empty) word being completed.</param>
        /// <param name="commandAst">The command ast in case it is needed for completion.</param>
        /// <param name="fakeBoundParameters">This parameter is similar to $PSBoundParameters, except that sometimes PowerShell cannot
        /// or will not attempt to evaluate an argument, in which case you may need to use commandAst.</param>
        /// <returns>
        /// A collection of completion results, most like with ResultType set to ParameterValue.
        /// </returns>
        public global::System.Collections.Generic.IEnumerable<global::System.Management.Automation.CompletionResult> CompleteArgument(global::System.String commandName, global::System.String parameterName, global::System.String wordToComplete, global::System.Management.Automation.Language.CommandAst commandAst, global::System.Collections.IDictionary fakeBoundParameters)
        {
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "DeviceOrdered".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'DeviceOrdered'", "DeviceOrdered", global::System.Management.Automation.CompletionResultType.ParameterValue, "DeviceOrdered");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "DevicePrepared".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'DevicePrepared'", "DevicePrepared", global::System.Management.Automation.CompletionResultType.ParameterValue, "DevicePrepared");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Dispatched".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Dispatched'", "Dispatched", global::System.Management.Automation.CompletionResultType.ParameterValue, "Dispatched");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Delivered".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Delivered'", "Delivered", global::System.Management.Automation.CompletionResultType.ParameterValue, "Delivered");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "PickedUp".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'PickedUp'", "PickedUp", global::System.Management.Automation.CompletionResultType.ParameterValue, "PickedUp");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "AtAzureDC".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'AtAzureDC'", "AtAzureDC", global::System.Management.Automation.CompletionResultType.ParameterValue, "AtAzureDC");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "DataCopy".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'DataCopy'", "DataCopy", global::System.Management.Automation.CompletionResultType.ParameterValue, "DataCopy");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Completed".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Completed'", "Completed", global::System.Management.Automation.CompletionResultType.ParameterValue, "Completed");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "CompletedWithErrors".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'CompletedWithErrors'", "CompletedWithErrors", global::System.Management.Automation.CompletionResultType.ParameterValue, "CompletedWithErrors");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Cancelled".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Cancelled'", "Cancelled", global::System.Management.Automation.CompletionResultType.ParameterValue, "Cancelled");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Failed_IssueReportedAtCustomer".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Failed_IssueReportedAtCustomer'", "Failed_IssueReportedAtCustomer", global::System.Management.Automation.CompletionResultType.ParameterValue, "Failed_IssueReportedAtCustomer");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Failed_IssueDetectedAtAzureDC".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Failed_IssueDetectedAtAzureDC'", "Failed_IssueDetectedAtAzureDC", global::System.Management.Automation.CompletionResultType.ParameterValue, "Failed_IssueDetectedAtAzureDC");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Aborted".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Aborted'", "Aborted", global::System.Management.Automation.CompletionResultType.ParameterValue, "Aborted");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "CompletedWithWarnings".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'CompletedWithWarnings'", "CompletedWithWarnings", global::System.Management.Automation.CompletionResultType.ParameterValue, "CompletedWithWarnings");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ReadyToDispatchFromAzureDC".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'ReadyToDispatchFromAzureDC'", "ReadyToDispatchFromAzureDC", global::System.Management.Automation.CompletionResultType.ParameterValue, "ReadyToDispatchFromAzureDC");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ReadyToReceiveAtAzureDC".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'ReadyToReceiveAtAzureDC'", "ReadyToReceiveAtAzureDC", global::System.Management.Automation.CompletionResultType.ParameterValue, "ReadyToReceiveAtAzureDC");
            }
        }
    }
}