using System;
using System.Text;
using TestPg.Products;

try
{
    Console.WriteLine(Environment.NewLine);
    string code = Utilities.Scanf("Enter product's code: ");
    string name = Utilities.Scanf("Enter product's name: ");
    string msg = ProductHelper.CreateProduct(code,name);
    Console.WriteLine("\n=========== OUTPUT ==========");
    Utilities.PrintLabel("Product found ",msg);
    Utilities.Pause();
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine("Press <ENTER> to continue");
Console.ReadLine();


