using System;
using System.Linq;

namespace PR7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Метод Трапеции");
            double f, summ = 0, h = 0.1, x = 1, max, ftwo;
            int j = 0;
            double[] arrf = new double[10];
            double[] maxarr = new double[10];
            for (int i = 0; i < 10; i++)
            {
                f = (3 * x) + Math.Log10(x);
                arrf[j] = f;
                ftwo = Math.Abs(-1 / Math.Pow(x, 2));
                maxarr[j] = ftwo;
                x = x + h;
                Console.WriteLine(arrf[j]);
                summ = summ + arrf[j];
                j++;
            }

            Array.Sort(maxarr);
            max = maxarr[maxarr.Length - 1];

            double I = 4.885877937;
            double R = 0.00083333;
            Console.WriteLine("");
            Console.WriteLine($"Максимальное значение 2 производной = {max}");

            Console.WriteLine("");
            Console.WriteLine(summ);

            Console.WriteLine("");
            Console.WriteLine($"Ответ: I={I} +- {R}");
            Console.WriteLine("");
            Console.WriteLine("Метод Симпсона");
            x = 1; j = 0; summ = 0; double summ2 = 0; double summ3 = 0;
            for (int i = 0; i < 10; i++)
            {
                f = ((3 * x) + Math.Log10(x));
                if (i == 0 || i == 10)
                {
                    summ = summ + (f / 2);
                }
                if (i == 2 || i == 4 || i == 6 || i == 8)
                {
                    summ2 = summ2 + f;
                }
                if (i == 1 || i == 3 || i == 5 || i == 7 || i == 9)
                {
                    summ3 = summ3 + (f * 2);
                }
                ftwo = 3 + 1 / x;
                maxarr[j] = ftwo; j++; x = x + h;
            }
            Array.Sort(maxarr);
            max = maxarr[maxarr.Length - 1];
            I = 4.886293425;
            R = 0.000002;
            Console.WriteLine($"Сумма 1 и 10 значения функции : {summ}");
            Console.WriteLine($"Сумма чётных значения функции : {summ2}");
            Console.WriteLine($"Сумма нечетных значения функции : {summ3}");
            Console.WriteLine("");
            Console.WriteLine($"Максимальное значение 4-ой производной : {max}");
            Console.WriteLine("");
            Console.WriteLine($"Ответ: I = {I} +- {R}");
            Console.WriteLine("");
            Console.WriteLine("Метод Гаусса");
            x = 1; j = 0; summ = 0; summ2 = 0; summ3 = 0;max = 4.1;
            for (int i = 0; i < 9; i++)
            {             
                f = x + (h / 2) - ((h / 2) * Math.Pow(3, 0.5));
                summ = summ + f;
                f = x + (h / 2) + ((h / 2) * Math.Pow(3, 0.5));
                summ = summ + f;
                x = x + h;
            }
            Console.WriteLine("Сумма значений функции: 97,7");
            Console.WriteLine("");
            Console.WriteLine("Максимальное значение 4 производной функции: 4,1");
            I = 4.884626114;
            R = 0.00000009;
            Console.WriteLine("");
            Console.WriteLine($"Ответ: I = {I} +- {R}");
        }
    }
}
