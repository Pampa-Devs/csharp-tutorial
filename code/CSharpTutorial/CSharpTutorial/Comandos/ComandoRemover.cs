using System.Collections.Generic;

namespace CSharpTutorial.Comandos
{
    public class ComandoRemover : Comando
    {
        public override void Executar(Stack<int> pilha)
        {
            if (pilha.Count == 0) throw new MaquinaErro("Não é possível executar 'POP' quando a pilha está vazia");

            pilha.Pop();
        }
    }
}