using System.Collections.Generic;

namespace CSharpTutorial.Commands
{
    public class DuplicateCommand : Command
    {
        public override void Execute(Stack<int> stack)
        {
            if (stack.Count == 0) throw new MachineException("Cannot use 'DUP' in empty stack");
            if (stack.Count == Machine.STACK_MAX_SIZE) throw new MachineException("Cannot use 'DUP' when stack is full");

            stack.Push(stack.Peek());
        }
    }
}
