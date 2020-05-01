using CSharpTutorial.Commands;
using System.Collections.Generic;

namespace CSharpTutorial
{
    public static class MachineCommands
    {
        public static Dictionary<EMachineCommands, Command> Commands = new Dictionary<EMachineCommands, Command>()
        {
            {  EMachineCommands.DUP, new DuplicateCommand() }
        };
    }
}