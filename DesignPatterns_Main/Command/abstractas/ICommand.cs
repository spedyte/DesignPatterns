using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Command.abstractas
{
    public interface ICommand
    {
        public string getcommandName();

        public void execute(string[] args);
    }
}
