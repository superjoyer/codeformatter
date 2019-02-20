using Microsoft.CodeAnalysis;

namespace Microsoft.DotNetCore.CodeFormatting.Interfaces
{
    internal interface IFormattingFilter
    {
        bool ShouldBeProcessed(Document document);
    }
}
