// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Support
{

    /// <summary>
    /// The signed permissions for the account SAS. Possible values include: Read (r), Write (w), Delete (d), List (l), Add (a),
    /// Create (c), Update (u) and Process (p).
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.PermissionsTypeConverter))]
    public partial struct Permissions :
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
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "r".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("r", "r", global::System.Management.Automation.CompletionResultType.ParameterValue, "r");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "d".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("d", "d", global::System.Management.Automation.CompletionResultType.ParameterValue, "d");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "w".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("w", "w", global::System.Management.Automation.CompletionResultType.ParameterValue, "w");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "l".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("l", "l", global::System.Management.Automation.CompletionResultType.ParameterValue, "l");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "a".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("a", "a", global::System.Management.Automation.CompletionResultType.ParameterValue, "a");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "c".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("c", "c", global::System.Management.Automation.CompletionResultType.ParameterValue, "c");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "u".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("u", "u", global::System.Management.Automation.CompletionResultType.ParameterValue, "u");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "p".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("p", "p", global::System.Management.Automation.CompletionResultType.ParameterValue, "p");
            }
        }
    }
}