using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // TestClass tc = new TestClass();
            // tc.TestMethod();
            //   RegularSavingAccount rs = new RegularSavingAccount();
            // rs.Balance(5000);
            //  rs.CalInterst();

            // Console.WriteLine("Rubb");
            // Console.WriteLine("arun");

            // Console.ReadKey();

            Stack myStack = new Stack();

            myStack.Push(5);
            myStack.Push(2);
            myStack.Push(30);
            myStack.Push(100);
            myStack.PrintStack();
            myStack.Peek();
            Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());
            myStack.PrintStack();
            Console.ReadKey();
        }
    }
}
