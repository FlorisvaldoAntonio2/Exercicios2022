using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Class
{
    public enum Operacao
    {
        Soma,
        Subtracao,
        Multiplicacao,
        Divisao
    }
    public static class Exec
    {
        public static void Questao01(float nota1, float nota2, float nota3)
        {
            float media = ((nota1 + nota2 + nota3) / 3);

            if (media >= 6)
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
            else if (idade < 5)
            {
                Console.WriteLine("Sem Faixa!!!");
                return;
            }


            if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("Infantil A");
            }
            else if (idade >= 8 && idade <= 10)
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
            if (numero % 2 == 0)
            {
                resultado += "PAR - ";
            }
            else
            {
                resultado += "IMPAR - ";
            }

            if (numero >= 0)
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
            while (cont <= 100)
            {
                if (cont % 2 == 0)
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
                if (cont == 0 || cont == 1)
                {
                    seq[cont] = cont;
                    cont++;
                    continue;
                }

                seq[cont] = seq[cont - 2] + seq[cont - 1];

                cont++;

            }

            foreach (var num in seq)
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

            } while (cont < 100);

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
                for (int num = cont; num >= 1; num--)
                {
                    if (cont % num == 0)
                    {
                        NumeroDivisiveis++;
                    }
                }

                if (NumeroDivisiveis <= 2)
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
                for (int t = 1; t <= 10; t++)
                {
                    Console.WriteLine($"{cont} X {t} = {cont * t}");
                }

                Console.WriteLine("-----------------------------");
            }
        }

        public static double Questao13(int numero)
        {
            if (numero < 1)
            {
                throw new ArgumentException("Parametro invalido!! O Numero deve ser POSITIVO e diferente de ZERO!!");
            }

            double resultado = 1.00; // ou 1d 

            for (int cont = 2; cont <= numero; cont++)
            {
                resultado += 1.00 / cont; // ou (double)1 / cont
            }

            return resultado;
        }

        public static void Questao14()
        {

        }

        public static float Questao15(float grau)
        {
            return ((9 * grau + 160) / 5);
        }

        public static double Questao16(float raio, float altura)
        {
            if (raio < 0 || altura < 0)
            {
                throw new ArgumentException("O raio e a altura devem ser POSITIVOS!!!");
            }
            return 3.14159 * raio * raio * altura;
        }

        public static void Questao17(float ladoA, float ladoB, float ladoC)
        {
            if (ladoA < 0 || ladoB < 0 || ladoC < 0)
            {
                throw new ArgumentException("Os lados devem ser POSITIVOS!!!");
            }

            if (ladoA + ladoB >= ladoC && ladoA + ladoC >= ladoB && ladoB + ladoC >= ladoA)
            {
                if (ladoA == ladoB && ladoB == ladoC)
                {
                    Console.WriteLine("triângulo é eqüilátero");
                }
                else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                {
                    Console.WriteLine("triângulo é isósceles");
                }
                else
                {
                    Console.WriteLine("triângulo será escaleno");
                }
            }
            else
            {
                Console.WriteLine("Não é um triangulo");
            }
        }

        public static string Questao18(int mes)
        {
            var Meses = new string[]
            {
                "Janeiro",
                "Fevereiro",
                "Maio",
                "Abril",
                "Marco",
                "Junho",
                "Julho",
                "Agosto",
                "Setembro",
                "Outubro",
                "Novembro",
                "Dezembro"
            };

            return Meses[mes - 1];

        }

        public static int Questao19(int numero1, int numero2, Operacao op)
        {
            int retorno = 0;

            if (op == Operacao.Soma)
                retorno = numero1 + numero2;

            if (op == Operacao.Subtracao)
                retorno = numero1 - numero2;

            if (op == Operacao.Multiplicacao)
                retorno = numero1 * numero2;

            if (op == Operacao.Divisao)
                retorno = numero1 / numero2;

            return retorno;

        }

        public static void Questao20(char letra)
        {
            if (letra == 'x' || letra == 'X')
            {
                Console.WriteLine("Sexo não informado");
                return;
            }
            else if (letra == 'm' || letra == 'M')
            {
                Console.WriteLine("Masculino");
                return;
            }
            else if (letra == 'f' || letra == 'F')
            {
                Console.WriteLine("Feminino");
                return;
            }

        }

        public static void Questao21()
        {
            var seqA = new int[10];
            //A
            for (int c = 0 , cont = 10; c < 10; c++)
            {
                seqA[c] = cont - c;           
            }

            var seqB = new int[10];
            //B
            for (int c = 0, cont = 10; c < 10; c++)
            {
                if (c == 0)
                {
                    seqB[c] = 1;
                    continue;
                }

                if(c < 5)
                {
                    seqB[c] = seqB[c - 1] + 1;
                    continue;
                }

                seqB[c] = seqB[c - 5] * 10;
                
            }

            var seqC = new int[10];
            //C
            for (int c = 0; c < 10; c++)
            {
                if(c == 0)
                {
                    seqC[c] = 1;
                    continue;
                }
                seqC[c] = seqC[c - 1] + 2;
            }

            var seqD = new int[10];

            //D
            for (int c = 0; c < 10; c++)
            {
                if(c == 0)
                {
                    seqD[c] = 2;
                    continue;
                }
                
                seqD[c] = seqD[(c - 1)] * 2;
            }

            Helper.ExibirArray<int>(seqA);
            Helper.ExibirArray<int>(seqB);
            Helper.ExibirArray<int>(seqC);
            Helper.ExibirArray<int>(seqD);
        }

        public static int Questao22(int[] array)
        {
            int contador = 0;
            foreach(var item in array)
            {
                if(item < 0)
                {
                    contador++;
                }
            }

            return contador;
        }

        public static int Questao23(int[] array, int x)
        {
            int contador = 0;
            foreach(var num in array)
            {
                if(num == x)
                {
                    contador++;
                }
            }
            return contador;
        }

        public static int[] Questao24(int[] array)
        {
            var arrayAux = new int[array.Length];

            for (int cont = 0; cont < array.Length; cont++)
            {
                if(array[cont] % 2 == 0)
                {
                    arrayAux[cont] = 1;
                }
                else
                {
                    arrayAux[cont] = -1;
                }
            }

            return arrayAux;
        }

        public static void Questao25()
        {

        }

        public static int Questao26(int[] array)
        {
            int maior = array[0];
            foreach(var item in array)
            {
                if(item > maior)
                {
                    maior = item;
                }
            }

            return maior;
        }

        public static int[,] Questao27(int[,] matriz1 , int[,] matriz2)
        {
            //implemnetar validação se as duas matrizes tem o mesmo tamanho

            var matrizAux = new int[matriz1.GetLength(0), matriz1.GetLength(1)];
    
            for (int l = 0; l < matriz1.GetLength(0); l++)
            {
                for (int c = 0; c < matriz1.GetLength(1); c++)
                {
                    matrizAux[l, c] = matriz1[l, c] + matriz2[l, c];
                }
            }

            return matrizAux;
        }

        public static int Questao28(int[,] matriz)
        {
            int total = 0;
            for (int l = 0; l < matriz.GetLength(0); l++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    if(l == c)
                    {
                        total += matriz[l, c];
                    }
                }
            }

            return total;
        }

        public static void Questao29()
        {

        }

        public static void Questao30()
        {

        }

        public static int[] Questao31(int[] array)
        {
            var arrayAux = new int[array.Length];
            for(int cont = 0; cont < array.Length; cont++)
            {
                if(array[cont] < 0)
                {
                    arrayAux[cont] = 1;
                }
                else
                {
                    arrayAux[cont] = array[cont];
                }
            }

            return arrayAux;
        }
    }
}
