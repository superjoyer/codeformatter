﻿using Microsoft.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.DotNetCore.CodeFormatting.Interfaces
{
    /// <summary>
    /// Base formatting rule which helps establish which language the rule applies to.
    /// </summary>
    public interface IFormattingRule
    {
        bool SupportsLanguage(string languageName);
    }

    /// <summary>
    /// Rules which need no semantic information and operate on parse trees only.  
    /// </summary>
    public interface ISyntaxFormattingRule : IFormattingRule
    {
        SyntaxNode Process(SyntaxNode syntaxRoot, string languageName);
    }

    /// <summary>
    /// Rules which possibly need semantic information but only operate on a specific document.  Also
    /// used for rules that need to see a <see cref="Document"/> and <see cref="SyntaxNode"/> which
    /// are in sync with each other,
    /// </summary>
    public interface ILocalSemanticFormattingRule : IFormattingRule
    {
        Task<SyntaxNode> ProcessAsync(Document document, SyntaxNode syntaxRoot, CancellationToken cancellationToken);
    }

    /// <summary>
    /// Rules which can affect more than the local document
    /// </summary>
    public interface IGlobalSemanticFormattingRule : IFormattingRule
    {
        Task<Solution> ProcessAsync(Document document, SyntaxNode syntaxRoot, CancellationToken cancellationToken);
    }
}
