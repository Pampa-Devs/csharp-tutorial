using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial.Commands
{
    public abstract class Command
    {
        public abstract void Execute(Stack<int> stack);
        public abstract void Undo(Stack<int> stack);

    }
}
