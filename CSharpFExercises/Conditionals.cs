using System;

namespace CSharpFExercises
{
    public class Conditionals : IExercise
    {
        public void Exercise1()
        {
            //<summary>
            //Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters 
            //a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in 
            //applications where values entered into input boxes need to be validated.)
            //</summary>

            Console.WriteLine("1 ile 10 arasında sayı giriniz");
            var input = Function.ReadLineToInt();

            if (input >= 1 && input <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("invalid");
        }

        public void Exercise2()
        {
            //<summary>
            //Write a program which takes two numbers from the console and displays the maximum of the two.
            //</summary>

            Console.WriteLine("Sayı giriniz");
            var input1 = Function.ReadLineToInt();

            Console.WriteLine("2. Sayı giriniz");
            var input2 = Function.ReadLineToInt();

            Console.WriteLine(input1 > input2 ? $"biggest one {input1}" : $"biggest one {input2}");
        }

        public void Exercise3()
        {
            //<summary>
            //Write a program and ask the user to enter the width and height of an image. Then tell if the image 
            //is landscape or portrait.
            //</summary>
            Console.WriteLine("width:");
            var width = Function.ReadLineToInt();

            Console.WriteLine("height");
            var height = Function.ReadLineToInt();

            Console.WriteLine(width > height ? "landscape" : "portrait");
        }

        public void Exercise4()
        {
            //<summary>
            //Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
            //etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
            //the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
            //display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
            //demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on 
            //the console. If the number of demerit points is above 12, the program should display License Suspended.
            //</summary>

            Console.WriteLine("SpeedLimit:");
            var speedLimit = Function.ReadLineToInt();
            Console.WriteLine("Car Speed:");
            var carSpeed = Function.ReadLineToInt();

            if (carSpeed < speedLimit)
                Console.WriteLine("Ok");

            var demeritPoints = (carSpeed - speedLimit) / 5;
            Console.WriteLine(demeritPoints > 12
                ? $"License Suspended, demeritPoints: {demeritPoints}"
                : $"Demerit Points: {demeritPoints}");
        }

        public void Exercise5()
        {
            //Write a program in C# Sharp to read any Month Number in integer and display Month name in the word
            Console.WriteLine("Hangi Ay ? (1-3)");
            var input = Function.ReadLineToInt();
            switch (input)
            {
                case 1:
                    Console.WriteLine("Ocak");
                    break;
                case 2:
                    Console.WriteLine("Şubat");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                default:
                    Console.WriteLine("1 ile 3 arasında bir rakam girmediniz");
                    break;
            }
        }
    }
}