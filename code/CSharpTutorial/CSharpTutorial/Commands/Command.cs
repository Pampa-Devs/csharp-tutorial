using System.Collections.Generic;

namespace CSharpTutorial.Commands
{
    public abstract class Command
    {
        public abstract void Execute(Stack<int> stack);
    }
}
