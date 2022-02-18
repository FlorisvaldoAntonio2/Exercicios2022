using Exercicios.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Exec.Questao01(10 , 0 , 0);

                //Exec.Questao02(-42);   

                //Exec.Questao03(1010 , 1000 ,1010);

                //Exec.Questao04(-11);

                //Exec.Questao05();

                //Exec.Questao06();

                //Exec.Questao07(8);

                //Exec.Questao08();

                //Exec.Questao09();

                Exec.Questao10();

                //Exec.Questao11(45 , 450 , 450);

                //Exec.Questao12();

           
                //Console.WriteLine(Exec.Questao13(-2));

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
