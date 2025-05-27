using System;

namespace PlataformaEnergia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Sistema de Monitoramento de Energia");
            Sistema sistema = new Sistema();
            sistema.Menu();
        }
    }
}