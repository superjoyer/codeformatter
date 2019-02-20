using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Microsoft.DotNetCore.CodeFormatting.Interfaces
{
    public interface IRuleMetadata
    {
        [DefaultValue("")]
        string Name { get; }

        [DefaultValue("")]
        string Description { get; }

        [DefaultValue(int.MaxValue)]
        int Order { get; }

        [DefaultValue(true)]
        bool DefaultRule { get; }
    }
}
