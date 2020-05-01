using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial.Commands
{
    public abstract class Command
    {
        public abstract void Execute(Stack<int> stack);
    }
}
