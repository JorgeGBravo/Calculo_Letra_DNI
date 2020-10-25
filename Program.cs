using System;

namespace Calculo_Letra_DNI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dime tu numero de DNI y te diré tu letra.");
            int numerodni =int.Parse(Console.ReadLine());
            //int numero = int.Parse(numerodni);
            Letras dni = new Letras(numerodni);
            Console.WriteLine(dni.Dni + dni.Letra);
            
        }
    }
}
