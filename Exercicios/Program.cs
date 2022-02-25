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

                // Console.WriteLine($"Total : {Exec.Questao19(10 , 2 , Operacao.Divisao )}");

                //Exec.Questao20('x');

                //Exec.Questao21();

                //Console.WriteLine(Exec.Questao22(new int[] {0 , -45 , -1 , 10}));

                //Console.WriteLine(Exec.Questao23(new int[] { 12 , 10, -45, -1, 10 , 10 } , 10));

                //Helper.ExibirArray(Exec.Questao24(new int[] {10 , -1 , -4 , -7 , -1}));

                Exec.Questao25(); //-->falta

                //Console.WriteLine(Exec.Questao26(new int[] {10 , 15 , 300 , 58 , 2940}));

                //Helper.ExibirMatriz(Exec.Questao27( new int[,] { { 12, 12, 45 }, { 1, 41, 80 } } , 
                //                                     new int[,] { { 12, 12, 45 }, { 1, 41, 80 } } 
                //                                    )
                //                    );

                //Console.WriteLine(Exec.Questao28(new int[,] { 
                //                                                { 12 , 12 , 45 , 74 , 10}, 
                //                                                { 01 , 18 , 80 , 10 , 10},
                //                                                { 12 , 12 , 10 , 74 , 10},
                //                                                { 12 , 12 , 45 , 10 , 10},
                //                                                { 12 , 12 , 45 , 74 , 10}
                //                                             }
                //                                  )
                // );

                Exec.Questao29(); //-->falta

                Exec.Questao30(); //-->falta

                //Helper.ExibirArray(Exec.Questao31(new int[] { 10, -1, -4, -7, -1 }));

                //Exec.Questao32(100);

                Exec.Questao33(); //-->falta

                //Console.WriteLine(Exec.Questao34(
                //                        new int[] { 0, 3, 5, 6 } ,
                //                        new int[] { 2, 4, 9, 8 }
                //                  ));

                //Exec.Questao35(new int[,] { 
                //                            { 10 , 10 , 10 } ,
                //                            { 10 , -15 , 10 } ,
                //                            { 10 , -1 , 10 } ,
                //                            { 10 , 10 , 10 }
                //});

                //Exec.Questao36(new int[,]{
                //                            { 10 , 10 , 10 } ,
                //                            { 10 , 150 , 10 } ,
                //                            { 10 , 1 , 10 }
                // });

                //Helper.ExibirMatriz( Exec.Questao37(
                //                new int[,] {
                //                    {1, 2, 3},
                //                    {4, 5, 6}
                //                } ,
                //                new int[,] {
                //                    {1, 2, 3},
                //                    {4, 5, 6}
                //                }
                //));

                //Console.WriteLine(Exec.Questao38("Florisvaldo", "Florisvaldo"));

                //Console.WriteLine(Exec.Questao40("Florisvaldo"));

                Console.WriteLine(Exec.Questao41("10.01.2020"));

                //Console.WriteLine(Exec.Questao42("Florisvaldo da Silva Melo")); --> falta implementar

                //Exec.Questao43("Olá mundo!, Estou estudando C#!");

                //Console.WriteLine(Exec.Questao44("SUBI NO ONIBUS"));

                //Console.WriteLine(Exec.Questao45("a ligeira raposa marrom saltou sobre o cachorro cansado" , 3));


            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();
        }
    }
}
