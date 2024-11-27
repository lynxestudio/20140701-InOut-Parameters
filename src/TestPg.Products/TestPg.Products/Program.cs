using System;

namespace TestPg.Products
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\t+-------------------------------------------------+");
            Console.WriteLine("\t Program to insert a record in a PostgreSQL DB");
            Console.WriteLine("\t using a PL/SQL procedure.");
            Console.WriteLine("\t+--------------------------------------------------+");
            try
            {
                Console.WriteLine(Environment.NewLine);
                string code = Utilities.Scanf("Enter product's code: ");
                string name = Utilities.Scanf("Enter product's name: ");
                string msg = ProductHelper.CreateProduct(code, name);
                Console.WriteLine();
                Utilities.PrintLabel("Message > ", msg);
                Utilities.Pause();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
