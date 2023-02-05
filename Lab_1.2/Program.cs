using System;

namespace CSharp_Net_module1_1_2_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use "Debugging" and "Watch" to study variables and constants

            //1) declare variables of all simple types:
            //bool, char, byte, sbyte, short, ushort, int, uint, long, ulong, decimal, float, double
            // their names should be: 
            //boo, ch, b, sb, sh, ush, i, ui, l, ul, de, fl, d0
            // initialize them with 1, 100, 250.7, 150, 10000, -25, -223, 300, 100000.6, 8, -33.1
            // Check results (types and values). Is possible to do initialization?
            // Fix compilation errors (change values for impossible initialization)

            bool boo = true; /*1 но эти данные нельзя ввести в эту переную, из-за типов данных*/
            char ch = '1'; /*в char можно вместить только один симфол так как он всего двух байтный */
            byte b = 2;
            sbyte sb = 4;
            short sh = 1000;
            ushort ush = -25; /* не может принимать отрицательные значения*/
            int i = -223;
            uint ui = 300;
            long l = 100000.6; /*не может принимать дробные значение, нужно или конвертировать или парсить в добл*/
            ulong ul = 2;
            decimal de = -33.1;/*не может принимать дробные значение, нужно или конвертировать или парсить в добл*/
            float fl = 32.3F;
            double d = 3.14159265359;


            //2) declare constants of int and double. Try to change their values.

            const int Months = 32;
            Months = 23;
            const double qw = 43.6;
            // константу нельзя изменить так как, это н зименяемая переменная

            //3) declare 2 variables with var. Initialize them 20 and 20.5. Check types. 
            // Try to reinitialize by 20.5 and 20 (change values). What results are there?
            var g = 20;
            var a = 20.5;
            Console.WriteLine(g);
            Console.WriteLine(a);
            g = 40;
            a = 50.2;
            Console.WriteLine(g);
            Console.WriteLine(a);
            // 4) declare variables of System.Int32 and System.Double.
            // Initialize them by values of i and d0. Is it possible?
            System.Int32 e;
            System.Double r;
            e = 32;
            r = 21.7;
            Console.WriteLine(e);
            Console.WriteLine(r);

            if (true)
            {
                // 5) declare variables of int, char, double 
                // with names i, ch, do
                // is it possible?
                if (true)
                {
                    int i1 = 31;
                    char ch2 = 'd';
                    double do2 = 23.5;
                    Console.WriteLine(i1);
                    Console.WriteLine(ch2);
                    Console.WriteLine(do2);

                }

                // 6) change values of variables from 1)
                bool boo = false; /*1 но эти данные нельзя ввести в эту переную, из-за типов данных*/
                char ch = '2'; /*в char можно вместить только один симфол так как он всего двух байтный */
                byte b = 5;
                sbyte sb = 8;
                short sh = 3000;
                ushort ush = 25; /* не может принимать отрицательные значения*/
                int i = -2235;
                uint ui = 1300;
                long l = 1032; /*не может принимать дробные значение, нужно или конвертировать или парсить в добл*/
                ulong ul = 8;
                decimal de = -331;/*не может принимать дробные значение, нужно или конвертировать или парсить в добл*/
                float fl = 43.3F;
                double d = 3.14159265359;

                Console.WriteLine(boo);
                Console.WriteLine(ch);
                Console.WriteLine(b);
                Console.WriteLine(sb);
                Console.WriteLine(sh);
                Console.WriteLine(ush);
                Console.WriteLine(i);
                Console.WriteLine(ui);
                Console.WriteLine(l);
                Console.WriteLine(ul);
                Console.WriteLine(de);
                Console.WriteLine(fl);
                Console.WriteLine(d);

            }

            // 7)check values of variables from 1). Are they changed? Think, why
            bool boo = false; /* но эти данные нельзя ввести в эту переную, из-за типов данных*/
            char ch = '2'; /*в char можно вместить только один симфол так как он всего двух байтный */
            byte b = 5;
            sbyte sb = 8;
            short sh = 3000;
            ushort ush = 25; /* не может принимать отрицательные значения*/
            int i = -2235;
            uint ui = 1300;
            long l = 1032; /*не может принимать дробные значение, нужно или конвертировать или парсить в добл*/
            ulong ul = 8;
            decimal de = -331;/*не может принимать дробные значение, нужно или конвертировать или парсить в добл*/
            float fl = 43.3F;
            double d = 3.14159265359;

            Console.WriteLine(boo);
            Console.WriteLine(ch);
            Console.WriteLine(b);
            Console.WriteLine(sb);
            Console.WriteLine(sh);
            Console.WriteLine(ush);
            Console.WriteLine(i);
            Console.WriteLine(ui);
            Console.WriteLine(l);
            Console.WriteLine(ul);
            Console.WriteLine(de);
            Console.WriteLine(fl);
            Console.WriteLine(d);

            // 8) use implicit/ explicit conversion to convert variables from 1). 
            // Is it possible? 

            // Fix compilation errors (in case of impossible conversion commemt that line).
            // int -> char

            // bool -> short

            // double -> long

            // float -> char 

            // int to char

            // decimal -> double

            // byte -> uint

            // ulong -> sbyte
            {
                int a = 231;
                char g = 'a';
                Console.WriteLine(g);
            }

            {
                int aa = 21;
                int gg = 32;
                char c = (char)(aa + gg);
                Console.WriteLine(c);
            }

            // { bool s = true;
            //
            //     short ss = (short)(s);
            //     //я не как преобразовать 
            //}
            {

                double fd = 13.2;
                long df = (long)(fd);
                Console.WriteLine(df);
            }
            {
                float gg = 2F;
                char hh = (char)(gg);
                Console.WriteLine(hh);
            }
            {
                int k = 57;
                char nni = '5';
                Console.WriteLine(nni);
            }
            {

                decimal ed = 321;
                double eed = (double)(ed);
                Console.WriteLine(eed);

            }
            {
                byte by = 32;
                uint yb = by;
                Console.WriteLine(yb);
            }
            //{
            //    ulong ul_2 = 7658;
            //    sbyte ul_3 = (sbyte)(ul_2);
            //    //я не как преобразовать 
            //}

            // 9) and reverse conversion with fixing compilation errors.
            {
                int a = 432;
                char g = 'a';
                int aa = g;
                Console.WriteLine(aa);
            }
            {
                double fd = 13.2;
                double ff = 23.5;
                long df = (long)(fd);
                double ffdd = df;
                Console.WriteLine(ffdd);
            }
            {
                float gg = 23.6F;
                char hh = (char)(gg);
                float gh = hh;
                Console.WriteLine(gh);
            }
            {
                int k = 57;
                char nni = 'k';
                int kn = nni;
                Console.WriteLine(kn);
            }

            //{
            //     decimal ed = 321;
            //    double eed = (double)(ed);
            //    decimal edd = (decimal)(edd);
            //я не как преобразовать
            // }

            // {
            //     byte by = 32;
            //     uint yb = by;
            //     byte byy = yb;
            //я не как преобразовать
            //  }

            // 10) declare int nullable value. Initialize it with 'null'. 
            // Try to initialize variable i with 'null'. Is it possible?
            int? nullable = null;
            Console.WriteLine(nullable);

        }
    }
}
