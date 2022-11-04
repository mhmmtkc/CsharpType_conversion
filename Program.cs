﻿namespace type_conversion
{
    class Program
    {
        static void Main()
        {
            // implicit conversion = bilinçsiz dönüşüm
            byte a = 5;
            sbyte b = 6;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d: " + d);
            long h = d;
            Console.WriteLine("h: " + h);
            float i = h;
            Console.WriteLine("i: " + i);
            string e = "mustafa";
            char f = 'k';
            object g = e + f + d;
            Console.WriteLine("g: " + g);

            // explicit conversion = bilinçli dönüşüm
            Console.WriteLine("******* Explicit conversion ********");
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:" + y);
            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t:" + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: " + v);

            // ToString method
            Console.WriteLine("******** ToString Method ********");
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy: " + xx);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz: " + zz);


            //System.Convert
            Console.WriteLine("****** System.Convert ********");

            string s1 = "10", s2 = "20";
            int sayi1, sayi2, toplam;
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1 + sayi2;
            Console.WriteLine("toplam:" + toplam);


            //Parse
            Console.WriteLine("****** Parse method ********");

            ParseMethod();
        }
        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int num1;
            double double1;
            num1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);
            Console.WriteLine("num1:" + num1 + "\ndouble1:" + double1);

        }
    }
}