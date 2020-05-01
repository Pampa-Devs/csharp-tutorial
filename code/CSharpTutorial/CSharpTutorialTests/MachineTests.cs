using CSharpTutorial;
using Xunit;

namespace CSharpTutorialTests
{
    public class MachineTests
    {
        [Fact]
        public void EnterCommand_WhenNumber_ShouldAddToStack()
        {
            Machine machine = new Machine();

            machine.EnterCommand("5");

            Assert.Equal(5, machine.StackTop());
        }

        [Fact]
        public void EnterCommand_WhenNegativeNumber_ShouldThrowError()
        {
            Machine machine = new Machine();

            Assert.Throws<MachineException>(() => machine.EnterCommand("-5"));
        }

        [Fact]
        public void EnterCommand_WhenNumberGreaterThan999_ShouldThrowError()
        {
            Machine machine = new Machine();

            Assert.Throws<MachineException>(() => machine.EnterCommand("1000"));
        }

        [Fact]
        public void EnterCommand_WhenStackFull_ShouldThrowError()
        {
            Machine machine = new Machine();

            Assert.Throws<MachineException>(() =>
            {
                for (int i = 0; i < 11; i ++)
                {
                    machine.EnterCommand("5");
                }
            });
        }

        [Fact]
        public void EnterCommand_WhenDUP_ShouldDuplicate()
        {
            Machine machine = new Machine();

            machine.EnterCommand("5");
            machine.EnterCommand("DUP");

            Assert.Equal(5, machine.StackTop());
            Assert.Equal(2, machine.StackSize());
        }

        [Fact]
        public void EnterCommand_WhenDUP_AndEmptyStack_ShouldThrowError()
        {
            Machine machine = new Machine();

            Assert.Throws<MachineException>(() => machine.EnterCommand("DUP"));
        }

        [Fact]
        public void EnterCommand_WhenDUP_AndStackFull_ShouldThrowError()
        {
            Machine machine = new Machine();

            for (int i = 0; i < 10; i++)
            {
                machine.EnterCommand("5");
            }

            Assert.Throws<MachineException>(() => machine.EnterCommand("DUP"));
        }
    }
}
