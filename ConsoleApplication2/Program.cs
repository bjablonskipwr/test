using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {

        static void Test01()
        {
            var actions = new Action[3];
            var actionsp = new Action<int>[3];
            Func<string> f = () => { Console.WriteLine("Ala ma kota"); return "a"; };

            var tekst = "abc";

            /*for (int i = 0; i < tekst.Length; i++ ) 
            {
                actions[i] = () => Console.WriteLine(tekst[i]);
            }*/ 

            int i = 0;
            foreach (var c in tekst)
            {
                int j = i;
                actions[i] = () => Console.WriteLine(c);
                actionsp[i++] = x => Console.WriteLine(x*j);
            }

            foreach (Action<int> a in actionsp)
                a(2);

            Console.WriteLine(f());
            
        }


        static void Main(string[] args)
        {
            Test01();
            Console.ReadLine();
        }
    }
}
