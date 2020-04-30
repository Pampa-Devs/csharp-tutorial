using System;

namespace CSharpTutorial
{
    public class MachineException : Exception
    {
        public MachineException(string message) : base(message) 
        {
        }
    }
}
