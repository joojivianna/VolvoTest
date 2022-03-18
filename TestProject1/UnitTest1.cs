using Migration_Estudo.Controllers;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            CaminhaoController caminhao = new CaminhaoController();
            caminhao.Read();
        }
    }
}
