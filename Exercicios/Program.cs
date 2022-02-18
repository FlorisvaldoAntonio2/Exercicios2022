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

                Exec.Questao10();//-->falta

                //Exec.Questao11(45 , 450 , 450);

                //Exec.Questao12();

                //Console.WriteLine(Exec.Questao13(-2));

                Exec.Questao14(); //-->falta

                //Console.WriteLine(Exec.Questao15(-20));

                //Console.WriteLine($"O Volume da lata é de : {Exec.Questao16(1f , 10f)}");

                //Exec.Questao17(1 , -1 , 1);

                //Console.WriteLine($"O mês escolhido é : {Exec.Questao18(1)}");

                Console.WriteLine($"Total : {Exec.Questao19(10 , 2 , Operacao.Divisao )}");

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();
        }
    }
}
