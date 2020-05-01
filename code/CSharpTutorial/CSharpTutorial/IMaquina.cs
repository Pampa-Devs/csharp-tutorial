namespace CSharpTutorial
{
    public interface IMaquina
    {
        void EntrarComando(string texto);
        int TopoPilha();
        int TamanhoPilha();
    }
}
