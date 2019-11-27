using System;

namespace CSharpFExercises
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(
                    "Koşullu: 1 ~ Döngüler: 2 ~ ListeDiziler: 3 ~ Procedural: 4 (Çıkmak için quit yazınız)");
                var input = Console.ReadLine();

                if (input == "1")
                {
                    var input1 = Function.AlistirmaSec();
                    var conditionals = new Conditionals();

                    switch (input1)
                    {
                        case "1":
                            conditionals.Exercise1();
                            break;
                        case "2":
                            conditionals.Exercise2();
                            break;
                        case "3":
                            conditionals.Exercise3();
                            break;
                        case "4":
                            conditionals.Exercise4();
                            break;
                        case "5":
                            conditionals.Exercise5();
                            break;
                        default:
                            Console.WriteLine("1 ile 5 arasında bir rakam girmediniz");
                            break;
                    }
                }
                else if (input == "2")
                {
                    var input1 = Function.AlistirmaSec();
                    var loops = new Loops();
                    switch (input1)
                    {
                        case "1":
                            loops.Exercise1();
                            break;
                        case "2":
                            loops.Exercise2();
                            break;
                        case "3":
                            loops.Exercise3();
                            break;
                        case "4":
                            loops.Exercise4();
                            break;
                        case "5":
                            loops.Exercise5();
                            break;
                        default:
                            Console.WriteLine("1 ile 5 arasında bir rakam girmediniz");
                            break;
                    }
                }
                else if (input == "3")
                {
                    var input1 = Function.AlistirmaSec();
                    var list = new ListsEx();
                    switch (input1)
                    {
                        case "1":
                            list.Exercise1();
                            break;
                        case "2":
                            list.Exercise2();
                            break;
                        case "3":
                            list.Exercise3();
                            break;
                        case "4":
                            list.Exercise4();
                            break;
                        case "5":
                            list.Exercise5();
                            break;
                        default:
                            Console.WriteLine("1 ile 5 arasında bir rakam girmediniz");
                            break;
                    }
                }
                else if (input == "4")
                {
                    var input1 = Function.AlistirmaSec();
                    var prdc = new Procedural();
                    switch (input1)
                    {
                        case "1":
                            prdc.Exercise1();
                            break;
                        case "2":
                            prdc.Exercise2();
                            break;
                        case "3":
                            prdc.Exercise3();
                            break;
                        case "4":
                            prdc.Exercise4();
                            break;
                        case "5":
                            prdc.Exercise5();
                            break;
                        default:
                            Console.WriteLine("1 ile 5 arasında bir rakam girmediniz");
                            break;
                    }
                }
                else if (input == "quit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("1 ile 3 arasında bir seçim yapınız");
                }
            }
        }
    }
}