using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem
{




    interface inter1
    {

        String Userd(String Phn);
    }
    public class Userd
    {

        public string Phn;

        public  Userd(String Phn )
        {
            Console.WriteLine("                                                                           Library Contact:{0}",Phn);
        }

    }

    class Book
    {
        public int bookId;
        public string bookName;
        public int bookPrice;
        public int bookCount;
        public int x;
    }

    class Borrowp : Book              //Inhertance
    {
        public int userId;
        public string userName;
        public string userAddress;
        public int borrowBookId;
        public DateTime borrowDate;
        public DateTime rDate;
       
        public int borrowCount;
    }

    class Program
    {
        static List<Book> bookList = new List<Book>();
        static List<Borrowp> borrowList = new List<Borrowp>();
        static Book book = new Book();
        static Borrowp borrow = new Borrowp();


        static void Main(string[] args)
        {
            #region
            //Console.BackgroundColor = ConsoleColor.DarkRed;
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            ////Console.BackgroundColor = ConsoleColor.DarkMagenta;
            //Console.Write("::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            //Console.Write("::::::::                                  =================>     WELCOME TO  LIBRARY MANAGEMENT SYSTEM !!! <==============                                    :::::::::\n");
            ////Console.BackgroundColor = ConsoleColor.DarkMagenta;
            //Console.Write("::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            //Console.Write("::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\n\n");

            //Console.WriteLine("\n \n");
            //Console.BackgroundColor = ConsoleColor.Black;
            #endregion




            Console.WriteLine("                                                   ==================>   HELLO LIBRARIAN <===================   \n                         \n");
            Userd u = new Userd("1800-4525-565");

            Console.Write("Enter Librarian Name:");
            string user = Console.ReadLine();

            Console.Write("Enter the PassCode:");
            string password = Console.ReadLine();

            DateTime dt = DateTime.Now; //DATETIME 
            string p = "1234";

            

            if (password == p)
            {
                Console.WriteLine("Hi {0} you have logged in at =>{1}", user, dt);
                bool close = true;
                while (close)
                {
                    
                    Console.WriteLine("\nMenu\n" +
                    "1)Add book\n" +
                    "2)Delete book\n" +
                    "3)Search book\n" +
                    "4)Borrow book\n" +
                    "5)Return book\n" +
                    "6)Show book stock\n" +
                    "7)Exit\n\n");
                    Console.Write("\b Choose your option from menu :\b");

                    int c = int.Parse(Console.ReadLine());

                    if (c == 1)
                    {
                        GetBook();
                    }
                    else if (c == 2)
                    {
                        RemoveBook();
                    }
                    else if (c == 3)
                    {
                        SearchBook();
                    }
                    else if (c == 4)
                    {
                        Borrow();
                    }
                    else if (c == 5)
                    {
                        ReturnBook();
                    }
                    else if (c == 6)
                    {
                        ShowBook();
                    }
                    else if (c == 7)
                    {
                        Console.WriteLine("Thank you");
                        close = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option\nRetry !!!");
                    }
                }
            }
            else
            {
                Console.WriteLine("{0} you entered Incorrect Password Enter correct  password!!!", user);
            }
            Console.ReadLine();
        }



        //s

        




        public static void GetBook()
        {
            Book book = new Book();
            Console.WriteLine("Book Id:{0}", book.bookId = bookList.Count + 1);
            Console.Write("Book Name:");
            book.bookName = Console.ReadLine();
            Console.Write("Book Price:");
            book.bookPrice = int.Parse(Console.ReadLine());
            Console.Write("Number of Books:");
            book.x = book.bookCount = int.Parse(Console.ReadLine());
            bookList.Add(book);
        }




        public static void RemoveBook()
        {
            Book book = new Book();
            Console.Write("Enter Book id to be deleted : ");

            int Del = int.Parse(Console.ReadLine());

            if (bookList.Exists(x => x.bookId == Del))
            {
                bookList.RemoveAt(Del - 1);
                Console.WriteLine("Book id - {0} has been deleted", Del);
            }
            else
            {
                Console.WriteLine("Invalid Book id");
            }

            bookList.Add(book);
        }


        public static void SearchBook()
        {
            Book book = new Book();
            Console.Write("Search by BOOK id :");
            int find = int.Parse(Console.ReadLine());

            if (bookList.Exists(x => x.bookId == find))
            {
                foreach (Book searchId in bookList)
                {
                    if (searchId.bookId == find)
                    {
                        Console.WriteLine("Book id :{0}\n" +
                        "Book name :{1}\n" +
                        "Book price :{2}\n" +
                        "Book Count :{3}", searchId.bookId, searchId.bookName, searchId.bookPrice, searchId.bookCount);
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", find);
            }
        }

        //s
        public static void ShowBook()
        {
            Book book = new Book();
            Console.Write("Books in Stock Are:"); 
            

            foreach (Book searchId in bookList)
            {
                Console.WriteLine("                  -----------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("           Book id :{0}" + "           Book name :{1}" + "Book price :{2}" +       "Book Count :{3}", searchId.bookId, searchId.bookName, searchId.bookPrice, searchId.bookCount);
                Console.WriteLine("                  -----------------------------------------------------------------------------------------------------------------------------");

            }
        }




        //s

        //To borrow book details from the Library

        public static void Borrow()
        {
            Book book = new Book();
            Borrowp borrow = new Borrowp();
            Console.WriteLine("User id : {0}", (borrow.userId = borrowList.Count + 1));
            Console.Write("Name :");

            borrow.userName = Console.ReadLine();

            Console.Write("Book id :");
            borrow.borrowBookId = int.Parse(Console.ReadLine());
            Console.Write("Number of Books : ");
            borrow.borrowCount = int.Parse(Console.ReadLine());
            Console.Write("Contact Number :");
            borrow.userAddress = Console.ReadLine();

            borrow.borrowDate = DateTime.Now;
            Console.WriteLine("Today current Date - {0} and Time - {1}", borrow.borrowDate.ToShortDateString(), borrow.borrowDate.ToShortTimeString());

            Console.Write("Borrow book till date D/M/Y:");
            borrow.rDate = DateTime.Parse(Console.ReadLine());



            var d = (borrow.rDate - borrow.borrowDate).Days;
            //Console.WriteLine(" Date - {0} and Time - {1}", borrow.borrowDate.ToShortDateString(), borrow.borrowDate.ToShortTimeString());
            Console.WriteLine("{0} Borrowed book for {1} days", borrow.userName, d);
             
            if (bookList.Exists(x => x.bookId == borrow.borrowBookId))
            {
                foreach (Book searchId in bookList)
                {
                    if (searchId.bookCount >= searchId.bookCount - borrow.borrowCount && searchId.bookCount - borrow.borrowCount >= 0)
                    {
                        if (searchId.bookId == borrow.borrowBookId)
                        {
                            searchId.bookCount = searchId.bookCount - borrow.borrowCount;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Only {0} books are found", searchId.bookCount);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", borrow.borrowBookId);
            }
            borrowList.Add(borrow);
        }

        //To return borrowed book to the library 
        public static void ReturnBook()
        {
            Book book = new Book();
            Console.WriteLine("Enter Book details :");

            Console.Write("Book id : ");
            int returnId = int.Parse(Console.ReadLine());

            Console.Write("Number of Books:");
            int returnCount = int.Parse(Console.ReadLine());

            if (bookList.Exists(y => y.bookId == returnId))
            {
                foreach (Book addReturnBookCount in bookList)
                {
                    if (addReturnBookCount.x >= returnCount + addReturnBookCount.bookCount)
                    {
                        if (addReturnBookCount.bookId == returnId)
                        {
                            addReturnBookCount.bookCount = addReturnBookCount.bookCount + returnCount;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Count exists the actual count");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", returnId);
            }
        }
    }
}

