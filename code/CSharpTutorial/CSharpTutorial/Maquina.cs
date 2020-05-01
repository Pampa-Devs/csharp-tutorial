using CSharpTutorial.Comandos;
using System;
using System.Collections.Generic;

namespace CSharpTutorial
{
    public class Maquina : IMaquina
    {
        public const int TAMANHO_MAXIMO_PILHA = 10;

        private readonly Stack<int> _pilha;
        private readonly Dictionary<EMaquinaComandos, Comando> _comandos;

        public Maquina()
        {
            _pilha = new Stack<int>(TAMANHO_MAXIMO_PILHA);
            _comandos = MaquinaComandos.Comandos;
        }

        public void EntrarComando(string texto)
        {
            int numero;

            if (EhNumero(texto, out numero))
            {
                TentarAdicionarNumeroPilha(numero);
            }
            else
            {
                var comando = TentarPegarComandoDoTexto(texto);

                comando.Executar(_pilha);
            }
        }

        private bool EhNumero(string texto, out int numero)
        {
            return int.TryParse(texto, out numero);
        }

        private void TentarAdicionarNumeroPilha(int numero)
        {
            if (numero < 0 || numero > 999)
            {
                throw new MaquinaErro($"Numero deve estar entre 0 e 999");
            }

            if (_pilha.Count >= TAMANHO_MAXIMO_PILHA)
            {
                throw new MaquinaErro($"Pilha cheia");
            }

            _pilha.Push(numero);
        }

        private Comando TentarPegarComandoDoTexto(string texto)
        {
            if(MaquinaComandos.ComandoNomes.ContainsKey(texto))
            {
                return _comandos[MaquinaComandos.ComandoNomes[texto]];
            }

            throw new MaquinaErro($"Comando '{texto}' não existe");           
        }

        public int TopoPilha()
        {
            return _pilha.Peek();
        }

        public int TamanhoPilha()
        {
            return _pilha.Count;
        }
    }
}
