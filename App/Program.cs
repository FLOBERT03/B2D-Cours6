using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioBanque;

namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire compte = new CompteBancaire("Pierre", 100, "dollars");
            Console.WriteLine(compte.Decrire());

            Console.ReadKey();
        }
    }
}
