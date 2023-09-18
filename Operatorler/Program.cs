using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Aritmetiksel Operatörler

            ////Toplama   +
            ////Çıkarma   -
            ////Çartpma   *
            ////Bölme     /
            ////Atama     =
            ////Özel Operatörler
            ////+=, -=, *=, /=, ++, --

            ////Tanımlanan Değişkene veri atamak için kullanılır

            //int sayi1 = 13;
            //int sayi2 = 5;

            //int toplam = sayi1 + sayi2;
            //Console.Write("Toplam = ");
            //Console.WriteLine(toplam);

            ////Sayı1 den sayı 2 yi çıkart fark ismindeki değişkene at
            //int fark = sayi1 - sayi2;
            //Console.Write("Fark = ");
            //Console.WriteLine(fark);

            //int carpim = sayi1 * sayi2;
            //Console.Write("Çarpım = ");
            //Console.WriteLine(carpim);

            //int bolum = sayi1 / sayi2;
            //Console.Write("Bölüm = ");
            //Console.WriteLine(bolum);

            ////Bölme işleminin ondalık sonuç vermesini istiyorsak
            ////bölme işleminde kullanılan değişkenlerin
            ////double, float veya decimal olması gerekir

            //double sayi3 = 13;
            //double sayi4 = 5;

            //double bolum2 = sayi3 / sayi4;
            //Console.Write("Bölüm = ");
            //Console.WriteLine(bolum2);


            ////Mod =İki sayının birbirine bölümünden kalan
            //int mod = sayi1 % sayi2;
            //Console.Write("Mod = ");
            //Console.WriteLine(mod);

            //Console.WriteLine(sayi1);
            //sayi1 += 10;
            ////Sayı1 değişkeninin üzerine 10 ekle
            //Console.WriteLine(sayi1);

            //sayi1++;//Sayı1'in değerini 1 arttır
            //Console.WriteLine(sayi1);

            #endregion

            #region Karşılaştırma Operatörleri

            //Karşılaştırma operatörleri her zaman boolean veri döndürür.
            //Büyüktür >
            //Küçüktür <
            //Eşittir ==
            int sayi = 22;

            Console.Write("Sayı 10 dan büyük mü = ");
            Console.WriteLine(sayi > 10);
            Console.Write("Sayı 10 dan küçük mü = ");
            Console.WriteLine(sayi < 10);
            Console.Write("Sayı 10 a eşit mi = ");
            Console.WriteLine(sayi == 10);

            #endregion
        }
    }
}
