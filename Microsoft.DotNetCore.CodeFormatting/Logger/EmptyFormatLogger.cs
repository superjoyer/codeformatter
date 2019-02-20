using Microsoft.DotNetCore.CodeFormatting.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.DotNetCore.CodeFormatting.Logger
{
    /// <summary>
    /// This implementation just ignores all output from the formatter.  It's useful
    /// for unit testing purposes.
    /// </summary>
    internal sealed class EmptyFormatLogger : IFormatLogger
    {
        public void Write(string format, params object[] args)
        {
        }

        public void WriteLine(string format, params object[] args)
        {
        }

        public void WriteErrorLine(string format, params object[] argsa)
        {
        }

        public void WriteLine()
        {
        }
    }
}
