using System.Collections.Generic;
using Commander.Data;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            List<Command> commands = new List<Command>()
            {
                 new Command(){ Id = 0, HowTo = "Push", Line="git push", Platform="Windows" },
                 new Command(){ Id = 1, HowTo = "Commit", Line="git commit -m", Platform="Windows" },
                 new Command(){ Id = 2, HowTo = "Add files", Line="git add .", Platform="Windows" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command(){ Id = 0, HowTo = "Check status", Line="git status", Platform="Windows" };
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