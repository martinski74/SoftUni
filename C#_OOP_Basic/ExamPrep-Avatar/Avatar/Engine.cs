using System;
using System.Collections.Generic;
using System.Linq;

namespace Avatar
{
    public class Engine
    {
        private bool isRuning;
        private NationsBuilder nationsBuilder;

        public Engine()
        {
            this.isRuning = true;
            this.nationsBuilder = new NationsBuilder();
        }

       

        public void Run()
        {
            while (this.isRuning)
            {
                string inputCommand = Console.ReadLine();
                List<string> commandParameters = inputCommand.Split(' ').ToList();
                this.DistributeCommand(commandParameters);
            }
        }

        private void DistributeCommand(List<string> commandParameters)
        {
            string command = commandParameters[0];
            commandParameters.Remove(command);

            switch (command)
            {
                case "Bender":
                    this.nationsBuilder.AssigneBender(commandParameters);
                    break;
                case "Monument":
                    this.nationsBuilder.AssignMonument(commandParameters);
                    break;
                case "Status":
                    string status = this.nationsBuilder.GetStatus(commandParameters[0]);
                    this.OutputWiter(status);
                    break;
                case "War":
                    this.nationsBuilder.IssueWar(commandParameters[0]);
                    break;
                case "Quit":
                    string record = this.nationsBuilder.GetWarsRecord();
                    this.OutputWiter(record);
                    this.isRuning = false;
                    break;
            }
        }
        private void OutputWiter(string status)
        {
            Console.WriteLine(status);
        }

    }
}