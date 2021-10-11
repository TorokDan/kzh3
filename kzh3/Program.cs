using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kzh3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] szamok = Create();
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write(szamok[i] + " ");
            }
            Console.WriteLine();
            double[] randomSzamok = Create(10);
            for (int i = 0; i < randomSzamok.Length; i++)
            {
                Console.Write(randomSzamok[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(Negative(szamok));
            Rendez(ref szamok);
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine(szamok[i]);
            }

        }
        static double[] Create()
        {
            double[] tomb = { -6.5, 5.2, -7.1, 4.2, 6.0, 8.3, -0.7, -4.8, -9.1, 10 };
            return tomb;
        }
        static double[] Create(int n)
        {
            double[] tomb = new double[n];
            Random rnd = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(-100, 100);
            }
            return tomb;
        }
        static bool Negative(double[] tomb)
        {
            double negativ = 0;
            double pozitiv = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] < 0)
                {
                    pozitiv++;
                }
                if (tomb[i] > 0)
                {
                    negativ--;
                }
            }
            return negativ > pozitiv;
        }
        static void Rendez(ref double[] T)
        {
            for (int i = 1; i < T.Length; i++)
            {
                int j = i - 1;
                double seged = T[i];
                while (j >= 0 && T[j] < seged)
                {
                    T[j + 1] = T[j];
                    j--;
                }
                T[j + 1] = seged;
            }
        }
    }
}
