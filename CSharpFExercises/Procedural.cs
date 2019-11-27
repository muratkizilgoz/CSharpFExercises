using System;

namespace CSharpFExercises
{
    internal class Procedural : IExercise
    {
        public void Exercise1()
        {
            // <summary>
            // Write a program and ask the user to enter a few numbers separated by a hyphen. Work out 
            // if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
            // display a message: "Consecutive"; otherwise, display "Not Consecutive".
            // </summary>
            Console.WriteLine("Sayı dizisi giriniz. (Ardışık mı?) (Örn: 1-2-3-4-5)");
            var input = Console.ReadLine().Trim().Split('-');
            var result = Function.Ardisikmi(input, input.Length);
            Console.WriteLine(result ? "Ardışık sayılar" : "Ardışık değil");
        }

        public void Exercise2()
        {
            // <summary>
            // Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply 
            // presses Enter without supplying an input, exit immediately; otherwise, check to see if there are 
            // any duplicates. If so, display "Duplicate" on the console.
            // </summary>
            while (true)
            {
                Console.WriteLine("Sayı dizisi giriniz. (çıkmak için enter) (Örn: 1-2-3-4-5)");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) break;
                var inputArray = input.Trim().Split('-');
                var result = Function.MukerrerKayitVarmi(inputArray);
                Console.WriteLine(result ? "Mükerrer kayıt yok" : "Mükerrer kayıt");
            }
        }

        public void Exercise3()
        {
            // <summary>
            // Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
            // A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, 
            // display "Invalid Time". If the user doesn't provide any values, consider it as invalid time. 
            // </summary>
            Console.WriteLine("Saat giriniz (Örn: 01:00)");
            var result = Function.SaatGecerliMi(Console.ReadLine());
            Console.WriteLine(result ? "Ok" : "Geçersiz saat");
        }

        public void Exercise4()
        {
            // <summary>
            // Write a program and ask the user to enter a few words separated by a space. Use the words to 
            // create a variable name with PascalCase convention. For example, if the user types: 
            // "number of students", display "NumberOfStudents". Make sure the program is not dependent on 
            // the casing of the input. So if the input is "NUMBER OF STUDENTS", it should still display 
            // "NumberOfStudents". If the user doesn't supply any words, display "Error".
            // </summary>
            Console.WriteLine("Kelimeler giriniz: (Örn: Kalem silgi defter)");
            var result = Function.PascalCase(Console.ReadLine());
            Console.WriteLine($"PascalCase: {result}");
        }

        public void Exercise5()
        {
            // <summary>
            // Write a program and ask the user to enter an English word. Count the number of vowels 
            // (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 
            // 6 on the console. Make sure the program calculates the number of vowels irrespective of the 
            // casing of the word (eg "Inadequate", "inadequate" and "INADEQUATE" all include 6 vowels).
            // </summary>
            Console.WriteLine("İngilizce kelime giriniz");
            var result = Function.SesliHarfSayisi(Console.ReadLine());
            Console.WriteLine($"Sesli harf sayısı: {result}");
        }
    }
}