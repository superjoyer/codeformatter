using System;
using Microsoft.DotNetCore.CodeFormatting.Parser;
using Microsoft.DotNetCore.CodeFormatting.Engine;
using Microsoft.DotNetCore.CodeFormatting.Enums;
using Microsoft.DotNetCore.CodeFormatting;

namespace CodeFormatter
{
    internal static class Program
    {
        private static int Main(string[] args)
        {
            var result = CommandLineParser.Parse(args);
            if (result.IsError)
            {
                Console.Error.WriteLine(result.Error);
                CommandLineParser.PrintUsage();
                return -1;
            }

            var options = result.Options;
            int exitCode = ExecuteOperationByInputOptions(options);

            return exitCode;
        }



        private static int ExecuteOperationByInputOptions(CommandLineOptions options)
        {
            int exitCode = 0;
            switch (options.Operation)
            {
                case Operation.ShowHelp:
                    CommandLineParser.PrintUsage();
                    exitCode = 0;
                    break;

                case Operation.ListRules:

                    var ruleRunner = new RuleRunner();
                    ruleRunner.RunListRules();

                    exitCode = 0;
                    break;
                case Operation.Format:

                    var formatRunner = new FormatRunner();
                    exitCode = formatRunner.RunFormat(options);

                    break;
                default:
                    throw new Exception("Invalid enum value: " + options.Operation);
            }
            return exitCode;
        }
    }
}
