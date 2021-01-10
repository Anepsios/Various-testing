using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Various_testing
{
    class Program
    {
        enum Color
        {
            Red, Orange, Yellow, Green, Blue, Indigo, Violet
        }
        enum Season
        {
            Spring = 6,
            Summer,
            Autumn,
            Winter
        };
        interface I
        {
            void M();
        }
        abstract class C : I
        {
            public abstract void M();
        }
        static void somestring(ref string s)
        {
            s = "i changed";
        }

        const int x21 = 6;
        static void Main(string[] args)
        {
            Console.WriteLine("how % works " + 4 % 5);

            Methods.CheckDelegates();
            Console.WriteLine();

            Methods.UnderstandInterfaces();
            Console.WriteLine();

            Table table1 = new Table(4);
            Table table2 = new Table(6);
            table2 = table1;
            Console.WriteLine(table1.legs);
            table2.legs = 8;
            Console.WriteLine(table1.legs);
            Console.WriteLine();

            //x21 = 4;
            LikeList likelist = new LikeList() { Number1 = 5, Number2 = 8 };

            string s = "I havent's changed";
            somestring(ref s);
            Console.WriteLine(s);
            Console.WriteLine();

            Console.WriteLine("Get value or default");
            int? x11 = null;
            int x12 = x11.GetValueOrDefault();
            Console.WriteLine(x12);
            Console.WriteLine();


            Console.WriteLine("new and override");
            Vehicle veh1, veh2, veh3;
            veh1 = new Vehicle();
            veh2 = new Car();
            veh3 = new Van();
            veh1.method1();
            veh1.method2();
            veh2.method1();
            veh2.method2();
            veh3.method1();
            veh3.method2();
            Console.WriteLine();

            int asdf = 5;
            Console.WriteLine(++asdf);
            Console.WriteLine("see what ?? is");
            string pa = null;
            Console.WriteLine(pa ?? "balls");


            Console.WriteLine();
            Console.WriteLine("Default constructor things");
            defult something = new defult();


            Console.WriteLine();
            Console.WriteLine("default data values");
            myclassinsideclass clil = new myclassinsideclass();
            Console.WriteLine(clil.num);
            Console.WriteLine(clil.str);
            myclassinsideclass clil2 = new myclassinsideclass(5);

            
            IEnumerable<string> str1 = new List<string>();
            IList<string> str = new List<string>();
            ICollection<string> cikk = new List<string>();


            Console.WriteLine();
            Console.WriteLine("Enum things");
            var season = Season.Summer;
            Console.WriteLine((int)season);


            string[] str2 = { "Boston", "Los Angeles", "Seatle", "London", "New York" };
            IEnumerable<string> FilteredCities = from city in str2
                                                 where city.StartsWith("L") && city.Length < 15
                                                 orderby city
                                                 select  city;


            Console.WriteLine();
            Console.WriteLine("check composition");
            myclass cl = new myclass();
            Console.WriteLine();

            inheritClass c2 = new inheritClass();
            c2.mymethod();
            Console.WriteLine();

            inheritfromvirtual vr = new inheritfromvirtual();
            vr.showvirtual();

            int? p = null;
            try
            {
                int po = p.Value;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: p is null");
            }
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }

    class defult
    {
        int num;
        public defult()
        {
            Console.WriteLine(num);
            num = 5;
            Console.WriteLine(num);
        }
    }

    class MyGeneric<one, two>
    {
        private one data;

        public one value
        {
            get { return this.data; }
            set { this.data = value; }
        }

        private two data2;

        public two value2
        {
            get { return this.data2; }
            set { this.data2 = value; }
        }
    }

    class myclass
    {
        private string hi = "hello there";
        public myclassinsideclass inception = new myclassinsideclass();
        public myclass()
        {
            Console.WriteLine(hi);
        }
    }

    class myclassinsideclass
    {
        public int num;
        public string str;
        public myclassinsideclass()
        {
            Console.WriteLine("Can I has class inside?");
        }
        public myclassinsideclass(int? x = null)
        {
            Console.WriteLine(num + str);
            try
            {
                this.num = x.Value;
            }
            catch (Exception ex)
            {
                
            }
            this.str = "empty";
            Console.WriteLine(num + str);
        }

        public void mymethod()
        {
            Console.WriteLine("My method");
        }
    }

    class inheritClass : myclassinsideclass
    {
        public inheritClass() : base(null)
        {
            Console.WriteLine("this is the inherited clous");
        }

        public new void mymethod()
        {
            base.mymethod();
            Console.WriteLine("my method that hides the original method");
        }
    }

     abstract class virtualclass
    {
        public int x;
        public virtual void showvirtual()
        {
            Console.WriteLine("First virtual");
        }
        public void showx()
        {
            Console.WriteLine(x);
        }
        public abstract void abmethod();
    }
    class inheritfromvirtual : virtualclass
    {
        public override void showvirtual()
        {
            base.showvirtual();
            Console.WriteLine("Second virtual");
        }

        public override void abmethod()
        {
            Console.WriteLine("I was abstract last class");
        }
    }
}