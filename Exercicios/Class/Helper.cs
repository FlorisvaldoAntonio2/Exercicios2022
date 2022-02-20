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
    }
}
