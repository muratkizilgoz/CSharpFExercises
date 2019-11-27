using System;

namespace CSharpFExercises
{
    public class Loops : IExercise
    {
        public void Exercise1()
        {
            // <summary>
            // Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
            // Display the result on the console.
            // </summary>
            var counter = 0;
            for (var i = 0; i <= 100; i++)
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                    counter++;
                }

            Console.WriteLine($"Counter: {counter}");
        }

        public void Exercise2()
        {
            // <summary>
            // Write a program and continuously ask the user to enter a number. The loop terminates when the user 
            // enters “ok". Calculate the sum of all the previously entered numbers and display it on the console.
            // </summary>
            var toplam = 0;
            while (true)
            {
                Console.WriteLine("Sayı giriniz, durmak için ok yazınız");
                var input = Console.ReadLine();
                if (input == "ok") break;
                toplam += Convert.ToInt32(input);
            }

            Console.WriteLine($"toplam: {toplam}");
        }

        public void Exercise3()
        {
            // <summary>
            // Write a program which takes a single argument from the console, computes the factorial and prints the 
            // value on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
            // and display it as 5! = 120.
            // </summary>
            Console.WriteLine("Sayı giriniz");
            var input = Function.ReadLineToInt();
            var factorial = 1;
            for (var i = input; i > 1; i--) factorial *= i;

            Console.WriteLine($"faktoriyel: {factorial}");
        }

        public void Exercise4()
        {
            // <summary>
            // Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
            // If the user guesses the number, display “You won". Otherwise, display “You lost".
            // </summary>
            var random = new Random();
            var sayi = random.Next(1, 10);

            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine("Sayıyı tahmin et (1 ile 10 arasında)");
                var input = Function.ReadLineToInt();
                if (input == sayi)
                {
                    Console.WriteLine($"Kazandın, Sayı : {sayi}");
                    break;
                }

                if (input < 1 || input > 10)
                    Console.WriteLine("1 ile 10 arasında bir değer giriniz");
                if (i == 3)
                {
                    Console.WriteLine($"Kaybettin, Sayı: {sayi}");
                    break;
                }

                Console.WriteLine("Bilemedin");
            }
        }

        public void Exercise5()
        {
            // <summary>
            // Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the 
            // numbers and display it on the result. For example, if the user enters “5, 3, 8, 1, 4", the program should 
            // display 8 on the console.
            // </summary>

            Console.WriteLine("Sayı dizisi giriniz. (örn: 1, 2, 3, 4,5,6)");
            var input = Console.ReadLine().Trim().Split(',');

            Console.WriteLine("En buyuk sayı: " + Function.EnBuyukSayi(input));
        }
    }
}