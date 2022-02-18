using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Class
{
    public static class Exec
    {
        public static void Questao01(float nota1 , float nota2 , float nota3)
        {
            float media = ((nota1 + nota2 + nota3) / 3);

            if(media >= 6)
            {
                Console.WriteLine($"Aprovado, media : {media.ToString("n2")}");
            }
            else
            {
                Console.WriteLine($"Reprovado, media : {media.ToString("n2")}");
            }

        }

        public static void Questao02(int idade)
        {
            if(idade < 5 || idade > 120)
            {
                Console.WriteLine("Idade invalida!!!");
                return;
            }


            if(idade >= 5 && idade <= 7)
            {
                Console.WriteLine("Infantil A");
            }
            else if(idade >= 8 && idade <= 10)
            {
                Console.WriteLine("Infantil B");
            }
            else if (idade >= 11 && idade <= 13)
            {
                Console.WriteLine("Juvenil A");
            }
            else if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine("Juvenil B");
            }
            else
            {
                Console.WriteLine("Adulto");
            }
        }

        public static void Questao03(int valorA, int valorB, int valorC)
        {
            Console.WriteLine($"Valor A : {valorA} | Valor B : {valorB} | Valor C : {valorC}");
            if (valorA >= valorB && valorA >= valorC)
            {
                Console.WriteLine($"O maior valor é : {valorA}.");
            }
            else if (valorB >= valorA && valorB >= valorC)
            {
                Console.WriteLine($"O maior valor é : {valorB}.");
            }
            else
            {
                Console.WriteLine($"O maior valor é : {valorC}.");
            }
        }

        public static void Questao04(int numero)
        {
            string resultado = "";
            if(numero % 2 == 0)
            {
                resultado += "PAR - ";
            }
            else
            {
                resultado += "IMPAR - ";
            }

            if(numero >= 0)
            {
                resultado += "POSITIVO";
            }
            else
            {
                resultado += "Negativo";
            }

            Console.WriteLine(resultado);
        }

        public static void Questao05()
        {
            int cont = 0;
            while(cont <= 100)
            {
                if(cont % 2 == 0)
                {
                    Console.WriteLine(cont);
                }
                cont++;
            }
        }

        public static void Questao06()
        {

        }
    }
}
