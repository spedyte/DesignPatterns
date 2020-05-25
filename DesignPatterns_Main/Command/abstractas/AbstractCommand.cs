using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Command.abstractas
{
    public abstract class AbstractCommand : ICommand
    {
        public abstract void execute(string[] args);

        public abstract string getcommandName();

        public void write( String message)
        {
            System.Console.WriteLine(message);
        }
    }
}
