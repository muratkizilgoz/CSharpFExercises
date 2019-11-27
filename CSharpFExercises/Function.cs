using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpFExercises
{
    public class Function
    {
        public static int ReadLineToInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public static string AlistirmaSec()
        {
            Console.WriteLine("Alıştırma Seçiniz ? (1-5)");
            return Console.ReadLine();
        }

        public static int EnBuyukSayi<T>(T[] array)
        {
            var max = 0;
            var arrayInts = Array.ConvertAll(array, Convert2Int);
            foreach (var arrayInt in arrayInts)
                if (arrayInt > max)
                    max = arrayInt;

            return max;
        }

        public static int EnBuyukSayi<T>(T[] array, bool alternatif)
        {
            var max = 0;
            foreach (var a in array)
            {
                var number = Convert.ToInt32(a);
                if (number > max)
                    max = number;
            }

            return max;
        }

        public static List<int> KucuktenBuyuge<T>(T[] array, int adet)
        {
            var output = new List<int>();
            var arrayInts = Array.ConvertAll(array, Convert2Int);
            var list = arrayInts.ToList();


            while (output.Count != adet)
            {
                if (list.Count == 0) break;

                var min = list.Min();
                if (output.Contains(min))
                {
                    list.Remove(min);
                    continue;
                }

                output.Add(min);
                list.Remove(min);
            }

            return output;
        }

        public static bool Ardisikmi<T>(T[] array, int adet)
        {
            var list = KucuktenBuyuge(array, adet);

            for (var i = 1; i < list.Count; i++)
                if (list[i - 1] + 1 != list[i])
                    return false;
            return true;
        }

        public static bool MukerrerKayitVarmi<T>(T[] array)
        {
            var list = new List<T>();
            foreach (var t in array)
            {
                if (list.Contains(t)) return false;
                list.Add(t);
            }

            return true;
        }

        public static bool SaatGecerliMi(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return false;
            var saat = value.Trim().Split(':');
            if (saat.Length != 2) return false;
            var hour = Convert.ToInt32(saat[0]);
            var minute = Convert.ToInt32(saat[1]);
            if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59) return true;
            return false;
        }

        public static string PascalCase(string value)
        {
            var output = "";
            foreach (var s in value.Split(' '))
                output += char.ToUpper(s[0]) + s.ToLower().Substring(1);
            return output;
        }

        public static int SesliHarfSayisi(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return 0;
            //(a, e, o, u, i)
            var sesliHarfler = new char[5];
            sesliHarfler[0] = 'a';
            sesliHarfler[1] = 'e';
            sesliHarfler[2] = 'o';
            sesliHarfler[3] = 'u';
            sesliHarfler[4] = 'i';
            var sayac = 0;
            foreach (var s in value.ToLower())
                if (sesliHarfler.Contains(s))
                    sayac++;

            return sayac;
        }

        public static string Reverse(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return "Boş veri girdiniz";
            var reversed = new char[value.Length];
            for (var i = value.Length - 1; i >= 0; i--)
                reversed[value.Length - 1 - i] = value[i];
            return new string(reversed);
        }

        public static string Reverse(string value, bool alternatif)
        {
            //With Linq
            return new string((char[]) value.Reverse());
        }


        public static int Convert2Int<T>(T input)
        {
            return Convert.ToInt32(input);
        }
    }
}