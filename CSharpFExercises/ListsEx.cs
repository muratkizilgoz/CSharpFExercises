using System;
using System.Collections.Generic;

namespace CSharpFExercises
{
    public class ListsEx : IExercise
    {
        public void Exercise1()
        {
            // <summary>
            // Write a program and continuously ask the user to enter different names, until the user presses Enter 
            // (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
            // </summary>
            var isimler = new List<string>();
            while (true)
            {
                Console.WriteLine("İsim giriniz (çıkmak için enter)");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input) && isimler.Count != 0) break;
                isimler.Add(input);
            }

            //Index i1 = 3;  // number 3 from beginning
            //Index i2 = ^4; // number 4 from end
            Console.WriteLine($"ilk isim: {isimler[0]}, son girilen isim: {isimler[^1]}, Toplam: {isimler.Count}");
        }

        public void Exercise2()
        {
            // <summary>
            // Ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
            // Display the reversed name on the console.
            // </summary>
            Console.WriteLine("Veri giriniz: (Palindrome mu ?)");
            var input = Console.ReadLine();
            var reversed = Function.Reverse(input);
            Console.WriteLine(input == reversed
                ? $"Palindrome {input} == {reversed}"
                : $"Palindrome değil {input} != {reversed}");
        }

        public void Exercise3()
        {
            // <summary>
            // Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display 
            // an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them 
            // and display the result on the console.
            // </summary>
            var sayilar = new List<int>();
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("Sayı giriniz");
                var input = Function.ReadLineToInt();
                if (sayilar.Contains(input))
                {
                    Console.WriteLine("Bu sayıyı daha önce girdiniz");
                    i--;
                    continue;
                }

                sayilar.Add(input);
            }

            Console.WriteLine();
            sayilar.Sort();
            foreach (var i in sayilar)
                Console.WriteLine(i);
        }

        public void Exercise4()
        {
            // <summary>
            // Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may 
            // include duplicates. Display the unique numbers that the user has entered.
            // </summary>
            var sayilar = new List<int>();
            while (true)
            {
                Console.WriteLine("Sayı giriniz, çıkmak için quit yazınız");
                var input = Console.ReadLine().ToLower();
                if (input == "quit") break;
                sayilar.Add(Convert.ToInt32(input));
            }

            var unique = new List<int>();
            foreach (var i in sayilar)
            {
                if (unique.Contains(i))
                    continue;
                unique.Add(i);
            }

            Console.WriteLine();
            foreach (var i in unique) Console.WriteLine(i);
        }

        public void Exercise5()
        {
            // <summary>
            // Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is 
            // empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display 
            // the 3 smallest numbers in the list.
            // 
            // </summary>
            while (true)
            {
                Console.WriteLine("5 den fazla sayı giriniz. (Örn: 1,2, 3,4,5,3,2)");
                var input = Console.ReadLine().Trim().Split(',');
                if (string.IsNullOrWhiteSpace(input.ToString()) || input.Length < 5)
                {
                    Console.WriteLine("Invalid list try again");
                    continue;
                }

                var yazdir = Function.KucuktenBuyuge(input, 3);
                Console.WriteLine();
                foreach (var i in yazdir) Console.WriteLine(i);
                break;
            }
        }
    }
}