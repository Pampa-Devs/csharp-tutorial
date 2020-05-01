using System;

namespace CSharpTutorial
{
    public class MaquinaErro : Exception
    {
        public MaquinaErro(string mensagem) : base(mensagem) 
        {
        }
    }
}
