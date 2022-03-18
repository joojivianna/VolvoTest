using Migration_Estudo.Controllers;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CaminhaoController caminhao = new CaminhaoController();
            caminhao.Read();
        }
    }
}
