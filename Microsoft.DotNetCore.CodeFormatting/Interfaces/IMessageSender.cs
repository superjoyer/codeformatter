using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.DotNetCore.CodeFormatting.Interfaces
{
    public interface IMessageSender
    {
        void Send(string message);
    }
   
}
