using System.Collections.Generic;

namespace CSharpTutorial.Comandos
{
    public abstract class Comando
    {
        public abstract void Executar(Stack<int> pilha);
    }
}
