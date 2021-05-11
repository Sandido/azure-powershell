// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support
{

    /// <summary>Defines the MoveResource states.</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.MoveStateTypeConverter))]
    public partial struct MoveState :
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
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "AssignmentPending".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("AssignmentPending", "AssignmentPending", global::System.Management.Automation.CompletionResultType.ParameterValue, "AssignmentPending");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "PreparePending".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("PreparePending", "PreparePending", global::System.Management.Automation.CompletionResultType.ParameterValue, "PreparePending");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "PrepareInProgress".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("PrepareInProgress", "PrepareInProgress", global::System.Management.Automation.CompletionResultType.ParameterValue, "PrepareInProgress");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "PrepareFailed".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("PrepareFailed", "PrepareFailed", global::System.Management.Automation.CompletionResultType.ParameterValue, "PrepareFailed");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "MovePending".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("MovePending", "MovePending", global::System.Management.Automation.CompletionResultType.ParameterValue, "MovePending");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "MoveInProgress".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("MoveInProgress", "MoveInProgress", global::System.Management.Automation.CompletionResultType.ParameterValue, "MoveInProgress");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "MoveFailed".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("MoveFailed", "MoveFailed", global::System.Management.Automation.CompletionResultType.ParameterValue, "MoveFailed");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "DiscardInProgress".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("DiscardInProgress", "DiscardInProgress", global::System.Management.Automation.CompletionResultType.ParameterValue, "DiscardInProgress");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "DiscardFailed".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("DiscardFailed", "DiscardFailed", global::System.Management.Automation.CompletionResultType.ParameterValue, "DiscardFailed");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "CommitPending".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("CommitPending", "CommitPending", global::System.Management.Automation.CompletionResultType.ParameterValue, "CommitPending");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "CommitInProgress".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("CommitInProgress", "CommitInProgress", global::System.Management.Automation.CompletionResultType.ParameterValue, "CommitInProgress");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "CommitFailed".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("CommitFailed", "CommitFailed", global::System.Management.Automation.CompletionResultType.ParameterValue, "CommitFailed");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Committed".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Committed", "Committed", global::System.Management.Automation.CompletionResultType.ParameterValue, "Committed");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "DeleteSourcePending".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("DeleteSourcePending", "DeleteSourcePending", global::System.Management.Automation.CompletionResultType.ParameterValue, "DeleteSourcePending");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ResourceMoveCompleted".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ResourceMoveCompleted", "ResourceMoveCompleted", global::System.Management.Automation.CompletionResultType.ParameterValue, "ResourceMoveCompleted");
            }
        }
    }
}