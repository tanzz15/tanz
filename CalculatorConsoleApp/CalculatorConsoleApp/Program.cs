using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            //float a = 10; //declarasi variabel a, dg nilai awal 10;
            //float b = 6; //declarasi variabel b, dg nilai awal 6;

            Console.Write("Inputkan nilai a=");
            float a = float.Parse(Console.ReadLine()); //proses casting

            Console.Write("Inputkan nilai b=");
            float b = Convert.ToInt32(Console.ReadLine()); //proses casting

            Console.WriteLine(); //tambahkan baris kosong

            Console.WriteLine("Hasil Penambahan " + a + "+" + b + "=" + Penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan  {0}-{1}={2}", a, b, Pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian {0}*{1}={2}", a, b, Perkalian(a, b));
            Console.WriteLine("Hasil Pembagian {0}/{1}={2}", a, b, Pembagian(a, b));

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }
        static float Penambahan(float a, float b)
        {
            return a + b;
        }
        static float Pengurangan(float a, float b)
        {
            return a - b;
        }
        static float Perkalian(float a, float b)
        {
            return a * b;
        }
        static float Pembagian(float a, float b)
        {
            return a / b;
        }
    }
}
