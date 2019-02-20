using Microsoft.DotNetCore.CodeFormatting.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.DotNetCore.CodeFormatting.RuleAttributes
{
    public class RuleMetadata : IRuleMetadata
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Order { get; set; }

        public bool DefaultRule { get; set; }
    }
}
