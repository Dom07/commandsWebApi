﻿using CommandsWebApi.Models;
using System.Collections.Generic;

namespace CommandsWebApi.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(int id)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            List<Command> commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Design the api", Line = "Plan on how to build the api", Platform = "DevJob" },
                new Command { Id = 1, HowTo = "Devlop the api", Line = "Code the api", Platform = "A coding machine" },
                new Command { Id = 2, HowTo = "Deploy the api", Line = "Ship the api on some hosting service", Platform = "Hoster" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Design the api", Line = "Plan on how to build the api", Platform = "DevJob" };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}
