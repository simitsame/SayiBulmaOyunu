using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RastgeleSayi
{
    class Program
    {
        static Random rastgele = new Random();
        int tahmin, sayi = rastgele.Next(1,11);
        

        static void Main(string[] args)
        {
            
            Program za = new Program();
            while (true)
            {
                
                Console.Write("Sayı giriniz: ");
                za.tahmin = Convert.ToInt32(Console.ReadLine());
                if (za.tahmin > za.sayi)
                {
                    Console.WriteLine("DAHA küçük BİR SAYI GİRİNİZ");
                }
                else if (za.tahmin < za.sayi)
                {
                    Console.WriteLine("daha BÜYÜK bir sayı giriniz");
                }
                else
                {
                    Console.WriteLine("helal dostum");
                }

            }

        }
    }
}
