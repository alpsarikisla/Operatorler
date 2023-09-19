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

            ////Karşılaştırma operatörleri her zaman boolean veri döndürür.
            ////Büyüktür      >
            ////Küçüktür      <
            ////Eşittir       ==
            ////Büyük Eşit    >=
            ////Küçük Eşit    <=
            ////Eşit Değil    !=
            ////Değil(Tersi)  !   boolean verinin tersini yazar
            //int sayi = 22;

            //Console.Write("Sayı 10 dan büyük mü = ");
            //Console.WriteLine(sayi > 10);
            //Console.Write("Sayı 10 dan küçük mü = ");
            //Console.WriteLine(sayi < 10);
            //Console.Write("Sayı 10 a eşit mi = ");
            //Console.WriteLine(sayi == 10);
            //Console.Write("Sayı 10'a büyük eşit mi = ");
            //Console.WriteLine(sayi >= 10);
          
            //Console.Write("Sayı 10'a küçük eşit mi = ");
            //Console.WriteLine(sayi <= 10);
            //Console.Write("sayı 10'a eşit değil mi = ");
            //Console.WriteLine(sayi != 10);//Eşit değil ise true getirir

            ////! her zaman başa yazılır
            //Console.WriteLine(!true);
            //Console.Write("sayı 10'dan büyük değil mi = ");
            //Console.WriteLine(!(sayi > 10));

            #endregion

            #region Mantıksal Operatörler

            //Mantıksal Operatörler Ve Veya komutlarına ihtiyaç duyduğumuzda kullanılır
            //Genellikle Karşılaştırma operatörleri ile birlikte kullanılır.
            //Boolean veri türleri ile koşulları çoğaltamak veya aynı koşula birden çok değişken eklemek için tercih edilir.
            //Mantıksal Operatörlerin sağında ve solunda boolean veri olmalıdır

            //&& Ve anlamında kullanılan Mantıksal operatörümdür
            //true && true      = true
            //true && false     = false
            //false && frue     = false
            //false && false    = false

            //|| Veya anlamında kullanılan Mantıksal operatörümdür
            //true || true      = true
            //true || false     = true
            //false || true     = true
            //false || false    = false

            int sayi = 21;

            //Sayı değişkeni içindeki veri 10 ile 20 arasında mı?
            Console.Write("Sayı = ");
            Console.WriteLine(sayi);
            Console.Write("10'dan büyük mü = ");
            Console.WriteLine(sayi > 10);
            Console.Write("Sayı 20'den Küçük mü = ");
            Console.WriteLine(sayi < 20);

            Console.Write("Sayı 10 ile 20 arasında mı = ");
            Console.WriteLine(sayi > 10 && sayi < 20);


            #endregion
        }
    }
}
