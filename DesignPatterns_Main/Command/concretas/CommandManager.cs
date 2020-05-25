using Command.abstractas;
using System;
using System.Collections.Generic;


namespace Command.concretas
{
    public class CommandManager
    {
        private static CommandManager manager;
        private static Dictionary<string, string> commands = new Dictionary<string, string>(); 
        
        private CommandManager()
        {
            register(ExitCommand.COMMAND_NAME, nameof(ExitCommand));
            register(DateCommand.COMMAND_NAME, nameof(DateCommand));
        }

        public  static CommandManager getManager() {
            if (manager == null)
                manager = new CommandManager();

            return manager;
        }

        public void register(string commandName,string clase)
        {
            commands.Add(commandName, clase);
        }

        public ICommand GetCommand(string command)
        {
            if (!commands.ContainsKey(command))
            {
                return new NotFoundCommand();
            }
            string className = commands.GetValueOrDefault(command);
            var tipo = Type.GetType("Command.concretas." + className);

            ICommand instance = (ICommand)Activator.CreateInstance(tipo);
            return instance;
        }
    }
}
