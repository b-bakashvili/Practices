using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models;

public class Book
{
    public int Id;
    public string Title;
    public string Author;
    public string Genre;
    public int PublishedYear;

    public void printInfo()
    {
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Genre: " + Genre);
        Console.WriteLine("Published Year: " + PublishedYear);
    }
}
