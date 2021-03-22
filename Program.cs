using System;

namespace MilhasParaKM
{
    class Program
    {
        static void Main(string[] args)
        {
            string medida;
            double milhas, km;

            Console.Write("Coloque abaixo uma medida em milhas para ser convertida para KM: ");
            medida = Console.ReadLine (); 

            milhas = Convert.ToDouble (medida);

            km = milhas * 1.609;

            Console.WriteLine("----------"); 
            Console.WriteLine($"A medida em km é: {km}");
        }
    }
}
