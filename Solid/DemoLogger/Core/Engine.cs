using DemoLogger.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLogger.Core
{
    public class Engine : IEngine
    {
        private ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            int appendersCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < appendersCount; i++)
            {
                string[] appenderArgs = Console.ReadLine().Split(' ');
                this.commandInterpreter.AddAppender(appenderArgs);
            }

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] messageArgs = input.Split('|');

                this.commandInterpreter.AddMessage(messageArgs);
            }

            this.commandInterpreter.PrintInfo();
        }
    }
}
