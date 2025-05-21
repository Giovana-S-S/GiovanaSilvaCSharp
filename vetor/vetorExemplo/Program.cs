using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetorExemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] vetNomes = new string[5];

            //vetNomes[0] = "Jenna";
            //vetNomes[1] = "Emma";
            //vetNomes[2] = "Sabrina";
            //vetNomes[3] = "Billie";

            Console.WriteLine("---As mais mais---");

            Console.WriteLine("Informe a primeira diva:");
            vetNomes[0] = Console.ReadLine();

            Console.WriteLine("Informe a segunda diva:");
            vetNomes[1] = Console.ReadLine();

            Console.WriteLine("Informe a terceira diva:");
            vetNomes[2] = Console.ReadLine();

            Console.WriteLine("Informe a quarta diva:");
            vetNomes[3] = Console.ReadLine();

            Console.WriteLine("Informe a quinta diva:");
            vetNomes[4] = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("---DIVAS BABILONICAS---");

            Console.WriteLine(vetNomes[0]);
            Console.WriteLine(vetNomes[1]);
            Console.WriteLine(vetNomes[2]);
            Console.WriteLine(vetNomes[3]);
            Console.WriteLine(vetNomes[4]);
        }
    }
}
