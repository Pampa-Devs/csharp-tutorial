using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial.Comandos
{
    public class ComandoClear : Comando
    {
        public override void Executar(Stack<int> pilha)
        {
            while(pilha.Count != 0)
            {
                pilha.Pop();
            }
        }
    }
}
