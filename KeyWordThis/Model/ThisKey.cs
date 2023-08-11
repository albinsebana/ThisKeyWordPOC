using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyWordThis.Model
{
    internal class ThisKey
    {
        private int number;
        private int value;
        private int myValue;


        public void Example1(int myValue)
        {
            this.myValue = myValue; // Use 'this' to refer to the instance variable
        }


        public void Example2(int number)
        {
            this.number = number;
        }

        public void PrintNumber()
        {
            Console.WriteLine($"The number is: {this.number}"); //used to access the  variable within the instance method.
        }
    }
}
//it is also used in  constructor chaining.
//public MyClass() : this(0)
