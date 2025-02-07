using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endeks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float kilo;
            float boy;
            float endeks;

            Console.WriteLine("Lütfen Kilonuzu girin");
            kilo = float.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen Boyunuzu girin");
            boy = float.Parse(Console.ReadLine());
            boy = boy / 100;
            endeks = kilo / (boy * boy);

           Console.WriteLine($"Yağ oranınız: {endeks}");

            if (endeks < 18.5)
            {
                Console.WriteLine("Düşük Kilolu");


            }
            else if (endeks < 24.9)
            {
                Console.WriteLine("Sağlıklı");
            }
            else if (endeks < 29.9)
            {
                Console.WriteLine("Fazla kilolu");
            }
            else if (endeks < 34.9)
            {
                Console.WriteLine("1. sınıf obezite");
            }
            else if (endeks < 39.9)
            {
                Console.WriteLine("2. sınıf obezite");
            }
            else
            {
                Console.WriteLine("3. sınıf obezite");
            }

        }
    }
}
