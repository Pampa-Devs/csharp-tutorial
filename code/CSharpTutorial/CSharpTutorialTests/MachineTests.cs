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

            Assert.Equal(5, machine.Top());
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
    }
}
