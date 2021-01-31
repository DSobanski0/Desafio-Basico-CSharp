using System;
using System.Linq;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroDeFigurinhas = Int32.Parse(Console.ReadLine());
            int numeroDeFigurinhasCompradas = Int32.Parse(Console.ReadLine());
            int totalDeFigurinhas = 0;

            int[] albumDeFigurinha = new int[numeroDeFigurinhas];

            // IMPLEMENTE AQUI A SOLUÇÃO
            int i = 0;
            int j = 0;
            while (i < numeroDeFigurinhasCompradas && j < albumDeFigurinha.Length)
            {
                int figurinha = int.Parse(Console.ReadLine());
                if (!albumDeFigurinha.Contains(figurinha))
                {
                    albumDeFigurinha[j] = figurinha;
                    j++;
                }
                i++;
            }

            totalDeFigurinhas = numeroDeFigurinhas;
            for (int z = 0; z < albumDeFigurinha.Length; z++)
            {
                if (albumDeFigurinha[z] > 0)
                {
                    totalDeFigurinhas--;
                }
            }

            Console.WriteLine(totalDeFigurinhas);
        }
    }
}