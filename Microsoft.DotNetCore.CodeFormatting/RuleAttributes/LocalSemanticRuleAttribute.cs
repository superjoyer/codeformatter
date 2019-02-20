using Microsoft.DotNetCore.CodeFormatting.Interfaces;
using System;
using System.ComponentModel;
using System.Composition;

namespace Microsoft.DotNetCore.CodeFormatting.RuleAttributes
{
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    internal sealed class LocalSemanticRuleAttribute : ExportAttribute, IRuleMetadata
    {
        public LocalSemanticRuleAttribute(string name, string description, int order)
            : base(typeof(ILocalSemanticFormattingRule))
        {
            Name = name;
            Description = description;
            Order = order;
            DefaultRule = true;
        }

        [DefaultValue("")]
        public string Name { get; private set; }

        [DefaultValue("")]
        public string Description { get; private set; }

        [DefaultValue(int.MaxValue)]
        public int Order { get; private set; }

        [DefaultValue(true)]
        public bool DefaultRule { get; set; }
    }
}
