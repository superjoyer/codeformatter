using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Microsoft.DotNetCore.CodeFormatting.Parser
{
    public class RspFileParser
    {
        public List<string> Parse(string rspContents)
        {
            List<string> outputListDocuments = new List<string>();
            var parseComments = Regex.Replace(rspContents, @"[#|[].+", "").Trim(new[] { '\r', '\n' });

            if (!string.IsNullOrEmpty(parseComments))
            {
                var documentsWithSpecialChars = Regex.Match(parseComments, @".+(.cs)").Value.Split(null);

                foreach (var curruntDoc in documentsWithSpecialChars)
                {
                    outputListDocuments.Add(Regex.Replace(curruntDoc, @"/[a-z|A_Z]{1}:", ""));
                }
            }

            return outputListDocuments;
        }

    }
}
