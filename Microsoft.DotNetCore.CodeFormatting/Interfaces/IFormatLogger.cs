using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.DotNetCore.CodeFormatting.Interfaces
{
    internal interface IFormatLogger
    {
        void Write(string format, params object[] args);
        void WriteLine(string format, params object[] args);
        void WriteLine();
        void WriteErrorLine(string format, params object[] args);
    }

}
