using CSharpTutorial.Comandos;
using System.Collections.Generic;

namespace CSharpTutorial
{
    public static class MaquinaComandos
    {
        public static Dictionary<string, EMaquinaComandos> ComandoNomes = new Dictionary<string, EMaquinaComandos>()
        {
            { "DUP", EMaquinaComandos.DUP },
            { "POP", EMaquinaComandos.POP },
            { "INV", EMaquinaComandos.INV },
            { "+", EMaquinaComandos.MAIS },
            { "-", EMaquinaComandos.MENOS },
            { "CLS", EMaquinaComandos.CLS }
        };

        public static Dictionary<EMaquinaComandos, Comando> Comandos = new Dictionary<EMaquinaComandos, Comando>()
        {
            {  EMaquinaComandos.DUP, new ComandoDuplicar() },
            {  EMaquinaComandos.POP, new ComandoRemover() },
            {  EMaquinaComandos.INV, new ComandoInverter() },
            {  EMaquinaComandos.MAIS, new ComandoMais() },
            {  EMaquinaComandos.MENOS, new ComandoMenos() },
            {  EMaquinaComandos.CLS, new ComandoClear() }
        };
    }
}