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
            if (idade < 0 || idade > 120)
            {
                throw new ArgumentException("Idade invalida deve ser MAIOR que ZERO e menor que 120!!!");
            }
            else if(idade < 5)
            {
                Console.WriteLine("Sem Faixa!!!");
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
            //int cont = 3;
            //int anterior1 = 1;
            //int anterior2 = 0;
            //int aux;

            //Console.Write($"{anterior2} - ");
            //Console.Write($"{anterior1} - ");

            //while (cont <= 100)
            //{
            //    Console.Write($"{anterior1 + anterior2} - ");
            //    aux = anterior2;
            //    anterior2 = anterior1;
            //    anterior1 = anterior1 + aux;

            //    cont++;
            //}

            var seq = new int[100];
            int cont = 0;

            while (cont < 100)
            {
                if(cont == 0 || cont == 1)
                {
                    seq[cont] = cont;
                    cont++;
                    continue;
                }

                seq[cont] = seq[cont - 2] + seq[cont - 1];

                cont++;
                    
            }

            foreach(var num in seq)
            {
                Console.WriteLine($"{num} - ");
            }
            
        }

        public static void Questao07(int numero)
        {
            int fatorial = numero;
            for (int cont = numero - 1; cont >= 1; cont--)
            {
                fatorial *= cont;
            }

            Console.WriteLine(fatorial);
        }

        public static void Questao08()
        {
            //Exercicios 05

            //int cont = 0;
            //do
            //{
            //    if (cont % 2 == 0)
            //    {
            //        Console.WriteLine(cont);
            //    }
            //    cont++;
            //} while (cont <= 100);

            //Exercicios 06

            var seq = new int[100];
            int cont = 0;

            do
            {
                if (cont == 0 || cont == 1)
                {
                    seq[cont] = cont;
                    cont++;
                    continue;
                }

                seq[cont] = seq[cont - 2] + seq[cont - 1];

                cont++;

            } while (cont < 100) ;

            foreach (var num in seq)
            {
                Console.WriteLine($"{num} - ");
            }
        }

        public static void Questao09()
        {
            int NumeroDivisiveis = 0;
            for (int cont = 1; cont <= 150; cont++)
            {
                for(int num = cont; num >= 1; num--)
                {
                    if(cont % num == 0)
                    {
                        NumeroDivisiveis++;
                    }
                }

                if(NumeroDivisiveis <= 2)
                {
                    Console.WriteLine(cont);
                }
                NumeroDivisiveis = 0;
            }
        }

        public static void Questao10()
        {

        }

        public static void Questao11(int valorA, int valorB, int valorC)
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

        public static void Questao12()
        {
            for (int cont = 1; cont <= 10; cont++)
            {
                for(int t = 1; t <= 10; t++)
                {
                    Console.WriteLine($"{cont} X {t} = {cont * t}");
                }

                Console.WriteLine("-----------------------------");
            }
        }

        public static double Questao13(int numero)
        {
            if(numero < 1)
            {
                throw new ArgumentException("Parametro invalido!! O Numero deve ser POSITIVO e diferente de ZERO!!");
            }

            double resultado = 1.00; // ou 1d 

            for(int cont = 2; cont <= numero; cont++)
            {
                resultado += 1.00 / cont; // ou (double)1 / cont
            }

            return resultado;
        }
    }
}
