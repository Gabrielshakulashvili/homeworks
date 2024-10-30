//// 1)
//using System;


//public class Book
//{
//    private string title;
//    private string author;
//    private string isbn;
//    private int copiesAvailable;



//    public Book(string title, string author, string isbn, int copiesAvailable)
//    {
//        Title = title;
//        Author = author;
//        Isbn = isbn;
//        CopiesAvailable = copiesAvailable;
//    }

//    public string Title
//    {
//        get { return title; }
//        set
//        {
//            if (string.IsNullOrEmpty(value))
//            {
//                throw new ArgumentException("satauri ar unda ikos carieli.");
//            }
//            else
//            {
//                title = value;
//            }
//        }
//    }

//    public string Author
//    {
//        get { return author; }
//        set { author = value; }
//    }


//    public string Isbn
//    {
//        set { isbn = value; }
//    }


//    public int CopiesAvailable
//    {
//        get { return copiesAvailable; }
//        set
//        {
//            if (value < 0)
//            {
//                throw new ArgumentException("aslebis odenoba uarkofiti cifri ver iqneba.");
//            }
//            else
//            {
//                copiesAvailable = value;
//            }
//        }
//    }


//    public void DisplayInfo()
//    {
//        Console.WriteLine("Title: " + title + " \n" + "Author: " + author + " \n" + "Isbn: " + isbn + " \n" + "copiesavailable: " + copiesAvailable);
//        Console.WriteLine("-----------------------------");

//    }





//    public void Borrowbook()
//    {
//        if (copiesAvailable > 0)
//        {
//            copiesAvailable--;
//            Console.WriteLine("tqven gaitanet wigni " + title + " darchenilia kidev " + copiesAvailable + " cali");
//            Console.WriteLine("-----------------------------");
//        }

//        else
//        {
//            Console.WriteLine("samwuxarod agar aris xelmisawvdomi");
//            Console.WriteLine("-----------------------------");

//        }

//    }


//    public void returnbook()
//    {

//        copiesAvailable++;
//        Console.WriteLine("tqven daabrunet wigni " + title + " xelmisawvdomia kidev " + copiesAvailable + " cali");
//        Console.WriteLine("-----------------------------");

//    }

//}



//class program
//{
//    static void Main()
//    {
//        Book mybook = new Book("vefxistkaosani", "shota rustaveli", "63a792d0", 50);

//        mybook.DisplayInfo();
//        mybook.Borrowbook();
//        mybook.returnbook();
//    }
//}



//2)

using System;
using System.Collections.Generic;
public class Library
{
    private List<string> yourbooks;

    public Library()
    {
        yourbooks = new List<string>();
    }

    public string Books
    {
        get { return Books; }
        set { Books = value; }
    }



    public void Addbook(string books)
    {
        yourbooks.Add(books);
        Console.WriteLine("tqven gaqvt " + yourbooks.Count + " cali  wigni");
    }


    public void removebook(string books)
    {
        yourbooks.Remove(books);
        Console.WriteLine("tqven gaqvt " + yourbooks.Count + " cali wigni");
    }


    public void displayAllBooks()
    {
        Console.WriteLine("tqveni wignebia: " + string.Join(", ", yourbooks));
    }


}




class program
{
    static void Main(string[] args)
    {
        Library myLibrary = new Library();


        myLibrary.Addbook("harry potter");
        myLibrary.Addbook("twilight");
        myLibrary.Addbook("the hobbit");
        myLibrary.removebook("the hobbit");
        myLibrary.displayAllBooks();

    }
}
