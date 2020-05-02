using System;

namespace CSharpTutorial
{
    public static class Program
    {
        public static void Main()
        {
            Maquina maquina = new Maquina();

            while(true)
            {
                Console.Write("Entre com um comando: ");
                string comando = Console.ReadLine();

                try
                {
                    maquina.EntrarComando(comando);
                    maquina.MostrarPilha();
                }
                catch(MaquinaErro erro)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(erro.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}