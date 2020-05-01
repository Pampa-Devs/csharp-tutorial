using CSharpTutorial.Comandos;
using System.Collections.Generic;

namespace CSharpTutorial
{
    public static class MaquinaComandos
    {
        public static Dictionary<EMaquinaComandos, Comando> Comandos = new Dictionary<EMaquinaComandos, Comando>()
        {
            {  EMaquinaComandos.DUP, new ComandoDuplicar() },
            {  EMaquinaComandos.POP, new ComandoRemover() },
        };
    }
}