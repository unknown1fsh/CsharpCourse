using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //CTRL + F5 Tuşu ile siyah ekran gelir ve bir tuşa basmamız istenir.(Console App)
            //Console.WriteLine("Hello World!");
            //Console.ReadLine(); (CTRL + F5 Tuşuna basmaya gerek kalmadan çalışan programı konsolda bekletir.

            //** VALUE TYPES **//

            // VERİ TİPLERİ

            // byte a = 0 - 255 (1 byte)

            // sbyte b = -128 / +127 (1 byte)

            // short c = -32768 / +32767 (2 byte)

            // ushort d = 0 - 65535 (2 byte)

            // int e = -2 147 483 468 / + 2 147 483 648 (4 byte)

            // uint f = 0 - 4 294 967 295 (4 byte)

            // long g = -10²⁰ / +10²⁰ (8 byte)

            // ulong h = 0 - 2 x 10²⁰ (8 byte)

            // boolean - bool = Mantıksal veri tipidir tuttuğu değer true / false' dır.

            // char character = 'A'  - Karakter veri tipi. Tek tırnak kullanılır.

            // double i = 0.4; (Ondalıklı sayı tutar)

            // decimal k = 0.18912612316; 

            // var keyword'ü değişken tutmak için kullanılır.

            // ENUM - Enum Sabitleri denir. Özetle şöyledir; Programda birçok değişkene tek tek sayısal değer vermek yerine "enum" kullanılabilir. Özet olarak "enum" yapısı sayıları anlamlı şekilde isimlendirerek kullanabilmeye izin verir.

            // En genel "enum" bildirimi şu şekilde yapılır :

            // public enum SehirPlakalari
        // {
        //     Ankara = 6, Kocaeli = 41, İzmir = 35, Adana = 1, Hatay = 31
        // }


        decimal number6 = 10.4m; // m harfi küçük ya da büyük olabilir M // 
            double number5 = 10.4;
            char character = 'A';
            string city = "Ankara"; // city 6 karaterden oluşan bir dizidir.
            bool condition = false;  //condition = şart
            byte number4 = 0;
            short number3 = 32767;
            int number1 = 2147483647;
            long number2 = 2147483648;
            var number7 = 10;
            number7 = 'A';
            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Number7 is {0}", number7); //İlk atamamız integer olduğu için A karakteri dikkate alınmaz.
            Console.WriteLine((int)Days.Friday); //Enum sabitleri değerlini 0'dan başlatır. Monday=10 Şeklinde de değer verilebilir 11,12 diye devam eder.
            Console.WriteLine("Character is : {0}", (int)character); //Bunun çıktısı 65'dir 65 ASCII Karater dizesinde "A" harfine denk gelir.
            Console.ReadLine();

            
        }

    }
    enum Days 
    {
        Monday=10,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}
