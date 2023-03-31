using System;

namespace delegatyy
{
    public delegate string FirstDelegate(int x);

    class DelegateTest
    {
        string name;

        static void Main()
        {
            FirstDelegate d1 = new FirstDelegate(DelegateTest.StaticMethod);

            DelegateTest instance = new DelegateTest();
            instance.name = "My instance";
            FirstDelegate d2 = new FirstDelegate(instance.InstanceMethod);

            Console.WriteLine(d1(10)); // Выводит на консоль "Static method: 10"
            Console.WriteLine(d2(5));  // Выводит на консоль "My instance: 5"
        }

        static string StaticMethod(int i)
        {
            return string.Format("Static method: {0}", i);
        }

        string InstanceMethod(int i)
        {
            return string.Format("{0}: {1}", name, i);
        }
    }



    class Program
    {
        public delegate string Gruzin();

        public delegate string Armyan();

        public delegate string Del();

        delegate int Monke(int x, int y);
            Monke = Del;
            Del = summ(x, y)
        {

        }
            del += Mult(x, y);
        static void Main(string[] args)
        {
            delegate int Del(int x, int y);
            Del = del;
            del = summ( x, y);
            del += Mult(x, y);
            public delegate void Gruzin(int Summa, int Vichitanie);

            static int summ(int x, int y) => Console.WriteLine(x + y);
            
         Gruzin += SayHello
        }

        void SayHello()
        {
        Console.WriteLine("Hello");
        }

        static void Summ(int x, int y) => Console.WriteLine($"{x} + {y} = {x + y}");

        static void Vichitanie(int x, int y) => Console.WriteLine($"{x} - {y} = {x - y}");
            
        delegate int Del(int x, int y);
        Del = del;
        del = summ(x, y);

        del += Mult(x, y);
    }
}