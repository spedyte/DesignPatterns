using Command.abstractas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Command.concretas
{
    public class ExitCommand : AbstractCommand
    {
        public static string COMMAND_NAME = "exit";
        public override void execute(string[] args)
        {
            write("Saliendo de la linea de comandos");
            Environment.Exit(0);
        }

        public override string getcommandName()
        {
            return COMMAND_NAME;
        }
    }
}
