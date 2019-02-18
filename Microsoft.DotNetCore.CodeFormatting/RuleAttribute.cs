﻿using System;
using System.ComponentModel;
using System.Composition;

namespace Microsoft.DotNetCore.CodeFormatting
{
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    internal sealed class SyntaxRuleAttribute : ExportAttribute, IRuleMetadata
    {
        public SyntaxRuleAttribute(string name, string description, int order)
            : base(typeof(ISyntaxFormattingRule))
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

    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    internal sealed class GlobalSemanticRuleAttribute : ExportAttribute, IRuleMetadata
    {
        public GlobalSemanticRuleAttribute(string name, string description, int order)
            : base(typeof(IGlobalSemanticFormattingRule))
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

    public class RuleMetadata : IRuleMetadata
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Order { get; set; }

        public bool DefaultRule { get; set; }
    }
}
