using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Various_testing
{
    public class Vehicle
    {
        public Vehicle()
        {
            method1();
        }
        public void method1()
        {
            Console.WriteLine("I has 4 wheels");
        }
        public virtual void method2()
        {
            Console.WriteLine("and i am generic");
        }
    }

    public class Car : Vehicle
    {
        public void method2()
        {
            Console.WriteLine("I am car");
        }
    }

    public class Van : Vehicle
    {
        public override void method2()
        {
            Console.WriteLine("I am van");
        }
    }

    public class LikeList
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
    }
    public class Table
    {
        public int legs;
        public Table(int num)
        {
            legs = num;
        }
    }

    public static class Methods
    {
        public static void UnderstandInterfaces()
        {
            int[] arr = new int[] { 5, 8, 3, 5, 1, 87, 34, 65, 23, 98, 67, 34, 65, 23, 1, 15, 71, 13, 12 };
            IEnumerable<int> que = from a in arr select a;
            Console.WriteLine();
        }

        public static void CheckDelegates()
        {
            myDelegate x = new myDelegate(delMethod);
            x();
            x = delegate () { Console.WriteLine("hey im anon delegate"); Console.WriteLine("Check me out"); };
            x();
            x = () => Console.WriteLine("Im lamdamale"); Console.WriteLine("in two lines"); ;
            x();
            lamdacheck yi = (a, b, c) => a + b + c;
            int yo = yi(1, 2, 3);
            lamdacheck y = (a, b, c) => { int result = a + b + c; Console.WriteLine("hmmm"); return result; };
            Console.WriteLine(y(1, 2, 3));
        }
        delegate int lamdacheck(int a, int b, int c);
        delegate void myDelegate();
        private static void delMethod()
        {
            Console.WriteLine("hey im a delmethod");
        }
    }
}
