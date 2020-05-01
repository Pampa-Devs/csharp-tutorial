using System.Collections.Generic;

namespace CSharpTutorial.Comandos
{
    public class ComandoInverter : Comando
    {
        public override void Executar(Stack<int> pilha)
        {
            if (pilha.Count == 0) throw new MaquinaErro("Não é possível executar 'INV' quando a pilha está vazia");

            var listaPilhaNumeros = new List<int>();

            while (pilha.Count > 0)
            {
                listaPilhaNumeros.Add(pilha.Pop());
            }
            
            foreach(var numero in listaPilhaNumeros)
            {
                pilha.Push(numero);
            }
        }
    }
}
