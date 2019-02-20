using Microsoft.DotNetCore.CodeFormatting.Interfaces;
using System;
using System.Composition;

namespace Microsoft.DotNetCore.CodeFormatting
{
    [Export(typeof(IMessageSender))]
    public class EmailSender : IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine(message);
        }
    }
}
