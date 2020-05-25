using Command.abstractas;
using Command.concretas;
using Command.util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Command
{
    public class CommandMain
    {
        public CommandMain()
        {
            /*
          TIPO  DE PATRON: Comportamiento (Tipo de patron utilizado )

          OBJETIVO :: Permite ejecutar oepraciones sin conocer los detalles de la implementacion de la misma.
                    Las operaciones son conocidas como comandos y cada operacion es implementada como una clase
                    independiente que realiza una accion muy concreta.

          TIPS: USar cuando es necesario encapsular los detalles de ejecucion de una serie de operacones bajo una 
                unica interface co Cuando es necesario ejecutar operaciones sin conocer los detalles de implementacion
                proporcionando un unico metodo de ejecucion.

          ESCENARIO: Crear una terminal de comandos, donde podremos ejecutar una serie de comandos previamente registrados.
                    Estos comandos seran ejecutados unicamente con el nombre del comando y los parametros requeridos.
                    Los comandos deberan ser operaciones encapsuladas, donde el usuario no conozca mas que la sintaxis
                    para ejecutarlos y no debera conocer los detalles de la implementacion.

          IMPLEMENTACION: La implementacion del patron se llama desde la clase ... 

         */
        }

        public void Run()
        {
            CommandManager commandManager = CommandManager.getManager();
            while (true)
            {
                string newLine = System.Console.ReadLine();
                if (string.IsNullOrEmpty(newLine.Trim()))
                {
                    continue;
                }

                string[] commandArgs= CommandUtil.tokenizerArgs(newLine);
                string commandName = commandArgs[0];
                string[] commandArgs2=null;
                if (commandArgs.Length > 1)
                {
                    List<string> paramsL = new List<string>();
                    for (int i = 1; i < commandArgs.Length; i++)
                    {
                        paramsL.Add(commandArgs[i]);
                    }
                    commandArgs2 = paramsL.ToArray();    
                }

                ICommand command = commandManager.GetCommand(commandName);
                command.execute(commandArgs2);

            }
           
        }
    }
}
