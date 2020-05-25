using Command.abstractas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command.concretas
{
    public class NotFoundCommand : AbstractCommand
    {
        public static string COMMAND_NAME = "notfound";
        public override void execute(string[] args)
        {
            write("Command not found...");
        }

        public override string getcommandName()
        {
            return COMMAND_NAME;
        }
    }
}
