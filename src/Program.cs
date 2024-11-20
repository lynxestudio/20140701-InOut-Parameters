using System;
using System.Text;
using TestPg.Products;

try
{
    Console.WriteLine(Environment.NewLine);
    Console.Write("Enter product's code: ");
    string code = Console.ReadLine();
    Console.WriteLine("Enter product's name: ");
    string name = Console.ReadLine();
    string msg = ProductHelper.CreateProduct(code,name);
    Console.WriteLine("\n=========== OUTPUT ==========");
    Console.WriteLine(msg);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine("Press <ENTER> to continue");
Console.ReadLine();


