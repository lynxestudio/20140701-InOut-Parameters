// -----------------------------------------------------------------------
// <copyright file="Utilities.cs" company="apifiedsignature">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace TestPg.Products
{
    using System;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    static class Utilities
    {
        internal static string Scanf(string message)
        {
            Console.Write("\t[ " + message + " ]\t");
            return Console.ReadLine();
        }

        internal static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("\tPress [Enter] to continue...");
            Console.ReadLine();
        }

        internal static void PrintLabel(string label, string value)
        {

            Console.WriteLine("\t{0}\t{1}", label, value);
        }
    }
}
