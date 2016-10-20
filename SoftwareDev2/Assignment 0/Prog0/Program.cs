// Program 0
// Starting Point

// File: Program.cs
// This file creates a simple test application class that creates
// an array of LibraryBook objects and tests them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Program
{
    // Precondition:  None
    // Postcondition: The LibraryBook class has been tested
    public static void Main(string[] args)
    {
        LibraryBook book1 = new LibraryBook("The Wright Guide to C#", "Andrew Wright", "UofL Press",
            2010, "ZZ25 3G");  // 1st test book
        LibraryBook book2 = new LibraryBook("Harriet Pooter", "IP Thief", "Stealer Books",
            2000, "AG773 ZF"); // 2nd test book
        LibraryBook book3 = new LibraryBook("The Color Mauve", "Mary Smith", "Beautiful Books Ltd.",
            1985, "JJ438 4T"); // 3rd test book
        LibraryBook book4 = new LibraryBook("The Guan Guide to SQL", "Jeff Guan", "UofL Press",
            -1, "ZZ24 4F");    // 4th test book
        LibraryBook book5 = new LibraryBook("The Big Book of Doughnuts", "Homer Simpson", "Doh Books",
            2001, "AE842 7A"); // 5th test book

        LibraryPatron patron1 = new LibraryPatron("Seth Rogen", "1737913");
        LibraryPatron patron2 = new LibraryPatron("James Franco", "1022664");
        LibraryPatron patron3 = new LibraryPatron("Kim Jong Un", "BANNED");

        List<LibraryBook> theBooks = new List<LibraryBook>() 
        { book1, book2, book3, book4, book5 }; // Creates a list of the above given books


        Console.WriteLine("Original list of books\n");
        PrintBooks(theBooks);

        // Make changes
        book1.CheckOut(patron1);
        book2.Publisher = "Borrowed Books";
        book3.CheckOut(patron2);
        book4.CallNumber = "AB123 4A";
        book5.CheckOut(patron3);

        Console.WriteLine("\nAfter changes\n");
        PrintBooks(theBooks);

        // Return all the books
        for (int i = 0; i < theBooks.Count; ++i)
            theBooks[i].ReturnToShelf();

        Console.WriteLine("\nAfter returning the books\n");
        PrintBooks(theBooks);
        }

        // Precondition:  None
        // Postcondition: The books have been printed to the console
        public static void PrintBooks(List<LibraryBook> books)
        {
            foreach (LibraryBook b in books)
            {
                Console.WriteLine(b);
                Console.WriteLine();
            }
        }
    }

