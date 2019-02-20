using Microsoft.DotNetCore.CodeFormatting.Engine;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.DotNetCore.CodeFormatting
{
    public class RuleRunner
    {
        public void RunListRules()
        {
            var rules = FormattingEngine.GetFormattingRules();
            Console.WriteLine("{0,-20} {1}", "Name", "Description");
            Console.WriteLine("==============================================");
            foreach (var rule in rules)
            {
                Console.WriteLine("{0,-20} :{1}", rule.Name, rule.Description);
            }
        }
    }
}
