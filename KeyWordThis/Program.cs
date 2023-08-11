using KeyWordThis.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyWordThis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThisKey myObject = new ThisKey();

            myObject.Example1(42);
            myObject.Example2(123);
            myObject.PrintNumber();

            Console.ReadLine();

        }
    }
}
