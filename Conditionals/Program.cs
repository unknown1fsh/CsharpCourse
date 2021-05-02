using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conditionals
{ //ŞART BLOKLARIYLA ÇALIŞMAK
    class Program
    {
        static void Main(string[] args)
        {
            var number = 11;
            //if (number==10) //Eğer sayı 10 ise.  // == Eşittir
            //{
            //    Console.WriteLine("Number is 10");
            //}
            //else if(number ==20)
            //{
            //    Console.WriteLine("Number is 20");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not 10 or 20");    
            //}

            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("Number is 10");
            //        break;//burada olayı kes break
            //    case 20:
            //        Console.WriteLine("Number is 20");
            //        break;
            //    default://bunlardan hiçbiri değilse.
            //        Console.WriteLine("Number is not 10 or 20");
            //        break;
            //}

            //***CTRL + K 'dan sonra CTRL + D KODU OKUNAKLI HALE GETİRİR***

            //if (number >= 0 && number <= 100)//&& ve demektir.
            //{
            //    Console.WriteLine("Number is betweed 0-100");
            //}
            //else if (number > 100 && number <= 200)
            //{
            //    Console.WriteLine("Number is betweed 101-200");
            //}
            //else if (number > 200 || number < 0) ; //   || işareti ya da veya demektir 2tane pipe dan oluşur. Sayımız 200'den büyükse veya sayımız küçüktür 0 sa if bloguna gir.
            //{
            //    Console.WriteLine("Number is less than 0 or greater than 200");
            //}

            //***İÇ İÇE İF BLOKLARIYLA ÇALIŞMAK***

            if (number < 100)
            {
                if (number >= 90 && number < 95)
                {
                    ///
                }
                else
                {
                    ///dsadasd
                }

            }

            Console.ReadLine();
        }
    }
}
