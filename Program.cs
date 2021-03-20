using System;

namespace MilhasParaKm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine("Converte Milhas em Km");
            Console.WriteLine("----------------------");

            double doubleMilhas;
            double doubleKm;
            
            Console.Write(" Quantas milhas você pretende andar hoje? ");
            doubleMilhas = Convert.ToDouble(Console.ReadLine());

            doubleKm = doubleMilhas * 1.609;
            Console.WriteLine($" Você percorreu uma distania de {doubleMilhas} milhas, o equivalente a {doubleKm:N2} Km");            
            
        }
    }
}
