using System;

namespace job_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double A, B, C, D;
                Console.WriteLine("Введите число А");
                A = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите число B");
                B = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите число C");
                C = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите число D");
                D = double.Parse(Console.ReadLine());
                Console.WriteLine("Остаток от деления на 3");
                double r1 = (A % 3 );
                Console.WriteLine("(1 число)=");
                Console.WriteLine(r1);
                double r2 = (B % 3);
                Console.WriteLine("(2 число)=");
                Console.WriteLine(r2);
                double r3 = (C % 3);
                Console.WriteLine("(3 число)=");
                Console.WriteLine(r3);
                double r4 = (D % 3);
                Console.WriteLine("(4 число)=");
                Console.WriteLine(r4);
                Console.WriteLine("***********************************************");
                Console.WriteLine("Остаток от деления на 5");
                double r5 = (A % 5);
                Console.WriteLine("(1 число)=");
                Console.WriteLine(r5);
                double r6 = (B % 5);
                Console.WriteLine("(2 число)=");
                Console.WriteLine(r6);
                double r7 = (C % 5);
                Console.WriteLine("(3 число)=");
                Console.WriteLine(r7);
                double r8 = (D % 5);
                Console.WriteLine("(4 число)=");
                Console.WriteLine(r8);
                
            
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();


        }
    }
}
