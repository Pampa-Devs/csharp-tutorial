using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial.Commands
{
    public class DuplicateCommand : Command
    {
        public override void Execute(Stack<int> stack)
        {
            stack.Push(stack.Peek());
        }
    }
}
