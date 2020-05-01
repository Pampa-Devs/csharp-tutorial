namespace CSharpTutorial
{
    public interface IMachine
    {
        void EnterCommand(string command);
        int StackTop();
    }
}
