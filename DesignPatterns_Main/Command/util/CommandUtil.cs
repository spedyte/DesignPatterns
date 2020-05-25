using System;
using System.Collections.Generic;
using System.Text;

namespace Command.util
{
    public class CommandUtil
    {
        public static  string[] tokenizerArgs(string line)
        {
            return line.Split(new char[] { ' ' });
        }
    }
}
