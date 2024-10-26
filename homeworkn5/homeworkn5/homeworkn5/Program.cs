//// 1)
//using System.Security.Cryptography.X509Certificates;

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
//        Title = title;
//        Author = author;
//        Isbn = isbn;
//        CopiesAvailable = copiesAvailable;
//    }

//    public string Title
//    { 
//       get { return title; } 
//       set
//        {
//            if (string.IsNullOrEmpty(value))
//            {
//                throw new ArgumentException("satauri ar unda ikos carieli.");
//            }
//            title = value;
//        }
//    }

//    public string Author
//    {
//       get { return author; }
//       set { author = value; }
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
//            copiesAvailable = value;
//        }
//    }


//    public void DisplayInfo()
//    {
//        Console.WriteLine("Title" + title + "\n", "Author" + author + "\n", "Isbn" + isbn + "\n", "copiesavailable" + copiesAvailable);
//    }

//    public void Borrowbook()
//    {
//        if (copiesAvailable <= 0) 
//        {
//            copiesAvailable--;
//            Console.WriteLine("tqven gaitanet wigni" + title + "darchenilia kidev" + copiesAvailable + "cali");
//        }

//        else
//        {
//            Console.WriteLine("samwuxarod agar aris xelmisawvdomi");
//        }

//    }


//    public void returnbook()
//        {

//        copiesAvailable++;
//        Console.WriteLine("tqven daabrunet wigni" + title + "xelmisawvdomia kidev" +  copiesAvailable + "cali" );

//        }

//}




// 2)

using System.Security.AccessControl;

public class Library
{
    private string books;


    //int yourbooks = 0;
    List<string> yourbooks;


    public Library(string books)
    {
        this.books = books;
    }

    public string Books
    {
        get { return books; }
        set { books = value; }
    }



    public void Addbook(string books)
    {
        yourbooks.Add(books);
        Console.WriteLine("tqven gaqvt" + yourbooks.Count + "odenobis wigni");
    }


    public void removebook()
    {
        yourbooks.Remove(books);
        Console.WriteLine("tqven gaqvt" + yourbooks.Count + "odenobis wigni");
    }


    public void displayAllBooks()
    {

        Console.WriteLine(string.Join(", ", yourbooks));
    }


}
