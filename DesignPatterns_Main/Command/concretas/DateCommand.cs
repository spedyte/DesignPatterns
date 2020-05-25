using Command.abstractas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command.concretas
{
    public class DateCommand : AbstractCommand
    {
        public static string COMMAND_NAME = "date";

        public override void execute(string[] args)
        {
            if (args==null || args.Length == 0)
            {
                write(DateTime.Now.ToString("dd/mm/yy hh:mm:ss"));
            }
            else {
                write(DateTime.Now.ToString(args[0]));
            }
        }

        public override string getcommandName()
        {
            return COMMAND_NAME;
        }
    }
}
