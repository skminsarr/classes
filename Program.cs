using System;

namespace basic
{


    class myclass
    {
        string nm = "myclass";
        internal void printname(string strnm)
        {
            Console.WriteLine(strnm);
            Console.WriteLine(nm);
        }
        internal int num()
        {
            Random rand = new Random();
            return rand.Next();
        }


    }

    class myclass2
    {
        private string strname;
        internal myclass2(string strnam)
        {
            strname = strnam;
        }
        internal void printnm()
        {
            Console.WriteLine(strname);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myclass obj = new myclass();
            //obj.nm = "xyz";
            obj.printname("avishek");
            int n = obj.num();
            Console.WriteLine(n);

            myclass2 obj2 = new myclass2("diamond");

            obj2.printnm();
        }
    }
}
