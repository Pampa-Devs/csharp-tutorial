using System.Collections.Generic;

namespace CSharpTutorial.Comandos
{
    public class ComandoMais : Comando
    {
        public override void Executar(Stack<int> pilha)
        {
            if (pilha.Count <= 1) throw new MaquinaErro("Não é possível executar '+' quando a pilha tem 1 ou menos elementos");

            var a = pilha.Pop();
            var b = pilha.Pop();

            pilha.Push(a + b);
        }
    }
}