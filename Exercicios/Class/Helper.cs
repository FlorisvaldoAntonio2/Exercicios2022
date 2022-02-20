using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Class
{
    public static class Helper
    {
        public static void ExibirArray<T>(T[] vetor)
        {
            foreach(var item in vetor)
            {
                Console.Write($"{item} | ");
            }

            Console.WriteLine("");
        }

        public static void ExibirMatriz<T>(T[,] matriz)
        {
            for(int l = 0; l < matriz.GetLength(0); l++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.Write($"{matriz[l , c]} | ");
                }

                Console.WriteLine();
            }
        }
    }
}
