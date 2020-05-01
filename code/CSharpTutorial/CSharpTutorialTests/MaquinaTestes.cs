using CSharpTutorial;
using Xunit;

namespace CSharpTutorialTests
{
    public class MaquinaTestes
    {
        [Fact]
        public void EntrarComando_QuandoNumero_DeveAdiconarNaPilha()
        {
            Maquina maquina = new Maquina();

            maquina.EntrarComando("5");

            Assert.Equal(5, maquina.TopoPilha());
        }

        [Fact]
        public void EntrarComando_QuandoNumeroNegativo_DeveLancarErro()
        {
            Maquina maquina = new Maquina();

            Assert.Throws<MaquinaErro>(() => maquina.EntrarComando("-5"));
        }

        [Fact]
        public void EntrarComando_QuandoNumeroMaiorQue999_DeveLancarErro()
        {
            Maquina maquina = new Maquina();

            Assert.Throws<MaquinaErro>(() => maquina.EntrarComando("1000"));
        }

        [Fact]
        public void EntrarComando_QuandoPilhaCheia_DeveLancarErro()
        {
            Maquina maquina = new Maquina();

            Assert.Throws<MaquinaErro>(() =>
            {
                for (int i = 0; i < 11; i ++)
                {
                    maquina.EntrarComando("5");
                }
            });
        }

        //[Fact]
        //public void EntrarComando_QuandoDUP_DeveDuplicarUltimoItemPilha()
        //{
        //    Maquina maquina = new Maquina();

        //    maquina.EntrarComando("5");
        //    maquina.EntrarComando("DUP");

        //    Assert.Equal(5, maquina.TopoPilha());
        //    Assert.Equal(2, maquina.TamanhoPilha());
        //}

        //[Fact]
        //public void EntrarComando_QuandoDUP_EhPilhaVazia_DeveLancarErro()
        //{
        //    Maquina maquina = new Maquina();

        //    Assert.Throws<MaquinaErro>(() => maquina.EntrarComando("DUP"));
        //}

        //[Fact]
        //public void EntrarComando_QuandoDUP_EhPilhaCheia_DeveLancarErro()
        //{
        //    Maquina maquina = new Maquina();

        //    for (int i = 0; i < 10; i++)
        //    {
        //        maquina.EntrarComando("5");
        //    }

        //    Assert.Throws<MaquinaErro>(() => maquina.EntrarComando("DUP"));
        //}

        //[Fact]
        //public void EntrarComando_QuandoPOP_DeveRemoverUltimoItemPilha()
        //{
        //    Maquina maquina = new Maquina();

        //    maquina.EntrarComando("5");
        //    maquina.EntrarComando("POP");
            
        //    Assert.Equal(0, maquina.TamanhoPilha());
        //}

        //[Fact]
        //public void EntrarComando_QuandoPOP_EhPilhaVazia_DeveLancarErro()
        //{
        //    Maquina maquina = new Maquina();

        //    Assert.Throws<MaquinaErro>(() => maquina.EntrarComando("POP"));
        //}
    }
}
