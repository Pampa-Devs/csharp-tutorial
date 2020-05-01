using CSharpTutorial.Commands;
using System;
using System.Collections.Generic;

namespace CSharpTutorial
{
    public class Machine : IMachine
    {
        private const int STACK_MAX_SIZE = 10;

        private readonly Stack<int> _stack;
        private readonly Dictionary<EMachineCommands, Command> _commands;

        public Machine()
        {
            _stack = new Stack<int>(STACK_MAX_SIZE);
            _commands = new Dictionary<EMachineCommands, Command>()
            {
                {  EMachineCommands.DUP, new DuplicateCommand() }
            };
        }

        public void EnterCommand(string text)
        {
            int number;

            if (IsNumber(text, out number))
            {
                PushNumberToStack(number);
            }
            else
            {
                var command = GetCommandFromText(text);

                command.Execute(_stack);
            }
        }

        private bool IsNumber(string text, out int number)
        {
            return int.TryParse(text, out number);
        }

        private void PushNumberToStack(int number)
        {
            if (number < 0 || number > 999)
            {
                throw new MachineException($"Number must be something between 0 and 999");
            }

            if (_stack.Count >= STACK_MAX_SIZE)
            {
                throw new MachineException($"Stack is full");
            }

            _stack.Push(number);
        }

        private Command GetCommandFromText(string text)
        {
            EMachineCommands machineCommands;

            if(Enum.TryParse(text, out machineCommands))
            {
                if (_commands.ContainsKey(machineCommands))
                {
                    return _commands[machineCommands];

                }
            }

            throw new MachineException($"Command '{text}' not implemented");           
        }

        public int Top()
        {
            return _stack.Peek();
        }
    }
}
