using System;
using System.Text;

namespace TestPgHelperProducts1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.WriteLine(Environment.NewLine);
            Console.Write(" Enter product's code: ");
            string code = Console.ReadLine();
            Console.Write(" Enter product's name: ");
            string name = Console.ReadLine();
            string msg = ProductHelper.CreateProduct(code, name);
            Console.WriteLine("\n============= OUTPUT===========\n");
            Console.WriteLine(msg);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("\nPress <ENTER> to continue");
            Console.ReadLine();
        }
    }
}
