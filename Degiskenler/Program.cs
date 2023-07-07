using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b =5;
            sbyte c = 5;
            short s = 5;
            ushort us = 55;
            
            Int16 i16 = 2;
            int i = 2;
            Int32 i32 = 2;
            Int64 i64 = 2;
            uint ui = 2;
            long l = 4;
            ulong ul = 4;

            //ReeI sayı lar
            float f = 5;
            double d = 5;
            decimal de = 5;

            char ch =  '2' ;
            // 2 byte
            string str = "Zikriye"; //sınırsız
            bool b1 = true;
            bool b2 = false;
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);


            object ol = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            // string ifadeler

            string str1 = string.Empty;
            str1 = "Gunes Mart";
            string ad = "Gunes";
            string soyad = "Mart";
            string tamIsim = ad + " " + soyad;

            // integer Tanımlama şekilleri

            int i1 = 5;
            int i2 = 5;
            int i3 = i1 + i2;

            //boolean

            bool bool1 = 10>2;

            // Değişken Dönüşümleri
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20+int20.ToString();

            Console.WriteLine(yeniDeger);

            int int21 = Convert.ToInt32(str20);
            Console.WriteLine(yeniDeger);

            int int22 = int20 + int.Parse(str20);

            //DateTime
            
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);

        }
    }
}
