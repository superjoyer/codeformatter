using Microsoft.CodeAnalysis;
using Microsoft.DotNetCore.CodeFormatting.Interfaces;
using System.Collections.Immutable;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.DotNetCore.CodeFormatting.Interfaces
{
    public interface IFormattingEngine
    {
        ImmutableArray<string> CopyrightHeader { get; set; }
        ImmutableArray<string[]> PreprocessorConfigurations { get; set; }
        ImmutableArray<string> FileNames { get; set; }
        ImmutableArray<IRuleMetadata> AllRules { get; }
        bool AllowTables { get; set; }
        bool Verbose { get; set; }
        void ToggleRuleEnabled(IRuleMetadata ruleMetaData, bool enabled);
        Task FormatSolutionAsync(Solution solution, CancellationToken cancellationToken);
        Task FormatProjectAsync(Project project, CancellationToken cancellationToken);
    }
}
