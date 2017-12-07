using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            HansOgGrethe();
            AwesomeApp();
        }

        static void Test()
        {
            Console.WriteLine("Metode 2");
        }


        static void HansOgGrethe()
        {
            Console.WriteLine("Metode 1");
            Test();
            Console.ReadLine();
        }

        static void AwesomeApp(){
            Console.WriteLine("This is an awesome app");
        }

    }
}

