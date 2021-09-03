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
            
            char ch = 'D';
            //int i = 0;
            string strnm = "NAME";
            //Console.WriteLine(ch);
            Console.WriteLine(strnm.Length);
            Console.WriteLine(strnm.ToLower());
            Console.WriteLine(strnm.IndexOf('A'));
            Console.WriteLine(strnm[2]);
            Console.WriteLine(strnm.Substring(0, 2));

            for(int i=0;i<strnm.Length;i++)
            {
                Console.WriteLine(strnm[i]);
            }

            int j = 7;
            while(j<5)
            {
                Console.WriteLine(j);
                j += 2;
                
            }
            do
            {
                Console.WriteLine(j + "inside do while");
            } while (j < 5);

            bool istrue = true;
            int[] arrnm = new int[5];
            arrnm[0] = 100;
            arrnm[1] = 200;
            for(int i=0;i<arrnm.Length;i++)
            {
                arrnm[i] = i;
                Console.WriteLine(arrnm[i]);

            }


            int[] arr2 = { 1, 2, 3, 4, 5, 6, 7,8 };
            for(int i=0;i<arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }

            foreach(int itm in arr2)
            {
                Console.WriteLine(itm);
            }

            string[] str = { "abc", "xyz", "diamond" };
            for(int i=0;i<str.Length;i++)
            {
                Console.WriteLine(str[i]);
            }

            foreach(string s in str)
            {
                Console.WriteLine(s);
            }

            double d = Math.Pow(2, 3);
            double d2 = Math.Sqrt(2);



            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());

            if(num<0)
            {
                Console.WriteLine("negative number");
            }
            else if(num>100)
            {
                Console.WriteLine("more than 100");
            }
            else
            {
                Console.WriteLine("positive number");
            }
            Console.WriteLine("Enter the month number");
            int mon = int.Parse(Console.ReadLine());

            switch(mon)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("feb");
                    break;
                default:
                    Console.WriteLine("march and above");
                    break;


            }
        }
    }
}
