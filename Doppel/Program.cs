using Microsoft.Extensions.CommandLineUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doppel
{
    internal class Program
    {
        private static CommandLineApplication _app;
        const string helpParams = "-?|-h|--help";

        public static void Main(string[] args)
        {
            _app = new CommandLineApplication();
            SetDocumentation();
            RegisterSyncCommand();

            _app.OnExecute(() =>
            {
                return 0;
            });

            _app.Execute(args);
        }

        public static void SetDocumentation() {
            _app.Name = "Doppel";
            _app.HelpOption(helpParams);
        }

        public static void RegisterSyncCommand() {
            _app.Command("mirror", (command) =>
            {
                command.Description = "Begin synchronizing the source to the destination.";
                command.HelpOption(helpParams);

                var sourceArg = command.Argument("[source]", "The URI path to mirror to the destination.");
                var destArg = command.Argument("[destination]", "The URI path that will receive the mirrored files.");

                command.OnExecute(() =>
                {
                    var sourcePath = sourceArg.Value;
                    var destPath = destArg.Value;

                    return 0;
                });
            });
        }
    }
}