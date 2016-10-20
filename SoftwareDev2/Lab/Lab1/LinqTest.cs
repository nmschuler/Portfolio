/* Nick Schuler
 * Lab 1
 * CIS 200-01
 * This program uses LINQ to order and select various invoices from the array and displays them*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1
{
    public class LinqTest
    {
        //Preconditions: no user entry except adding invocies. add as Part Number, Destription, quantity, and               price.
        //Postconditions: The program will run a Console Program.
        public static void Main(string[] args)
        {
            // initialize array of invoices
            Invoice[] invoices = { 
                new Invoice( 83, "Electric sander", 7, 57.98M ), 
                new Invoice( 24, "Power saw", 18, 99.99M ), 
                new Invoice( 7, "Sledge hammer", 11, 21.5M ), 
                new Invoice( 77, "Hammer", 76, 11.99M ), 
                new Invoice( 39, "Lawn mower", 3, 79.5M ), 
                new Invoice( 68, "Screwdriver", 106, 6.99M ), 
                new Invoice( 56, "Jig saw", 21, 11M ), 
                new Invoice( 3, "Wrench", 34, 7.5M )};

            //part a
            var sortedPartDescription =
                from pd in invoices
                orderby pd.PartDescription
                select pd;
            Console.WriteLine("\n(part a) Sorted by Part Description");
            foreach (var element in sortedPartDescription)
                Console.WriteLine(element);

            //part b
            var sortedPrice =
                from p in invoices
                orderby p.Price
                select p;
            Console.WriteLine("\n(part b) Sorted by Price");
            foreach (var element in sortedPrice)
                Console.WriteLine(element);

            //part c
            var quantSorted =
                from q in invoices
                orderby q.Quantity
                select new { q.Quantity, q.PartDescription };
            Console.WriteLine("\n(part c) Sorted by quantity, then display Part description and quantity");
            foreach (var element in quantSorted)
                Console.WriteLine(element);

            //part d: 
            var totalInvoice =
                from iT in invoices
                let InvoiceTotal = iT.Quantity * iT.Price
                orderby InvoiceTotal
                select new { InvoiceTotal, iT.PartDescription };
            Console.WriteLine("\n(Part d) Select each invoice PartDescription and value of Invoice");
            foreach (var element in totalInvoice)
                Console.WriteLine(element);  
            //how to get this currency format?

            //part e
            const decimal LOW_VALUE = 200M; //to hold low value of the range
            const decimal HIGH_VALUE = 500M; //to hold the high value of the range
            var invoiceRange =
                from iR in totalInvoice
                where iR.InvoiceTotal >= LOW_VALUE && iR.InvoiceTotal <= HIGH_VALUE
                select iR;
            Console.WriteLine("\n(Part e) Use part d, filter results between $200 - $500");
            foreach (var element in invoiceRange)
                Console.WriteLine(element);
            //how to get currency format?

        }
    }
}
