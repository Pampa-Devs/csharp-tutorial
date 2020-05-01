using System.Collections.Generic;

namespace CSharpTutorial.Comandos
{
    public class ComandoDuplicar : Comando
    {
        public override void Executar(Stack<int> pilha)
        {
            if (pilha.Count == 0) throw new MaquinaErro("Não é possível executar 'DUP' quando a pilha está vazia");
            if (pilha.Count == Maquina.TAMANHO_MAXIMO_PILHA) throw new MaquinaErro("Não é possível executar 'DUP' quando a pilha está cheia");

            pilha.Push(pilha.Peek());
        }
    }
}
