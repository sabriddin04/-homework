using Infrastructure.Services;
using Domain.Models;


var BookServices = new BookService();
/*
System.Console.WriteLine("");
System.Console.WriteLine("");
System.Console.WriteLine("");
System.Console.WriteLine("|<S>|<S>|<S>|<S>|<S>|<S>|<S>|<S>|<S>|<S>||<S>|<S>|<S>|<S>|<S>||<S>|<S>|<S>|<S>| Enter yours instructions : |<S>|<S>|<S>|<S>|<S>|<S>|<S>|<S>|<S>|<S>||<S>|<S>|<S>|<S>|<S>|<S>|<S>|");
System.Console.WriteLine("|<--------------------> Display");
System.Console.WriteLine("|<--------------------> Delete");
System.Console.WriteLine("|<--------------------> Update");
System.Console.WriteLine("|<--------------------> Add");
System.Console.WriteLine("|<--------------------> Exist");


while (true)
{
    System.Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
    string a = Console.ReadLine();

    switch (a)
    {
        case "display":
        case "Display":
        case "DISPLAY":
            System.Console.WriteLine("");
            System.Console.WriteLine("");
            System.Console.WriteLine("");
            System.Console.WriteLine("––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
            System.Console.WriteLine("|–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––|");
            System.Console.WriteLine("|                                                             TABLE OF BOOKS                                                              |");
            System.Console.WriteLine("|–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––|");
            System.Console.WriteLine("––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
            System.Console.WriteLine("––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
            System.Console.WriteLine("|  id  | \t\ttitle\t\t\t  |     author\t\t  |    ISBN    |       Janr      |  Dostup   |");
            foreach (var item in BookServices.GetBooks())
            {
                System.Console.WriteLine("–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                System.Console.Write($"| {item.Id}");
                System.Console.Write($" | {item.Title}");
                System.Console.Write($" | {item.FullName}");
                System.Console.Write($"| {item.Isbn}");
                System.Console.Write($" | {item.Name}");
                System.Console.Write($"| {item.Dostup} |\n");
            }
            System.Console.WriteLine("–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
            break;
        case "Delete":
        case "delete":
        case "DELETE":
            System.Console.WriteLine("Enter Book's id for delete :");
            int n = Convert.ToInt32(Console.ReadLine());
            string koftan = "naeft";
            foreach (var item in BookServices.GetBooks())
            {
                if (item.Id == n)
                {
                    koftan = "yoft";
                    System.Console.WriteLine("---------------------------ARE YOU SURE WANT TO DELETE?-----------------------------");

                    System.Console.WriteLine($" TITLE OF BOOK : {item.Title} ");
                    System.Console.WriteLine($" Author OF BOOK : {item.FullName} ");
                    System.Console.WriteLine($" ISBN OF BOOK : {item.Isbn} ");
                    System.Console.WriteLine($" Janr OF BOOK : {item.Name} ");
                    System.Console.WriteLine($" Dostup OF BOOK : {item.Dostup} ");
                    System.Console.WriteLine("____________________________ENTER YOUR ANSWER YES OR NO_________________________________");
                    string ot = Console.ReadLine();
                    if (ot == "yes" || ot == "YES") { System.Console.WriteLine("This BOOK succesfully deleted from BOOKS !!!"); BookServices.DeleteBook(n); }
                    else break;
                }

            }
            if (koftan == "naeft") System.Console.WriteLine("Not Founded BOOK with this Id !!!");
            break;

        case "Update":
        case "update":
        case "UPDATE":

            var book = new Books();
            System.Console.WriteLine("Enter BOOK'S Id which you want update:");
            int k = Convert.ToInt32(Console.ReadLine());
            book.Id = k;

            string koftan1 = "naeft";
            foreach (var item in BookServices.GetBooks())
            {
                if (item.Id == k)
                {
                    koftan1 = "yoft";
                    System.Console.WriteLine("---------------------------ARE YOU SURE WANT TO Update this Book?-----------------------------");
                    System.Console.WriteLine("____________________________ENTER YOUR ANSWER YES OR NO_________________________________");
                    string ot = Console.ReadLine();

                    if (ot == "yes" || ot == "YES")
                    {
                        System.Console.WriteLine($" His Past TITLE OF BOOK : {item.Title} ");
                        System.Console.WriteLine("Enter his new title :");
                        book.Title = Console.ReadLine();

                        System.Console.WriteLine($" His Past Author OF BOOK : {item.FullName} ");
                        System.Console.WriteLine("Enter his new Author :");
                        book.FullName = Console.ReadLine();
                        System.Console.WriteLine($" His Past ISBN OF BOOK : {item.Isbn} ");
                        System.Console.WriteLine("Enter his new ISBN :");
                        book.Isbn = Convert.ToInt64(Console.ReadLine());
                        System.Console.WriteLine($" His Past Janr OF BOOK : {item.Name} ");
                        System.Console.WriteLine("Enter his new Janr :");
                        book.Name = Console.ReadLine();
                        System.Console.WriteLine($" His Past Dostup OF BOOK : {item.Dostup} ");
                        System.Console.WriteLine("Enter his new Dostup :");
                        book.Dostup = Convert.ToBoolean(Console.ReadLine());
                        System.Console.WriteLine("-------------------------------------------------");
                        System.Console.WriteLine("This BOOK succesfully updated from BOOKS !!!");
                        System.Console.WriteLine("-------------------------------------------------");
                        BookServices.UpdateBook(book);
                    }
                    else break;
                }
            }
            if (koftan1 == "naeft") System.Console.WriteLine("Not Founded BOOK with this Id !!!");

            break;

        case "ADD":
        case "Add":
        case "add":
            var book1 = new Books();
            System.Console.WriteLine("Enter BOOK'S Title which you want add:");
            book1.Title = Console.ReadLine();
            System.Console.WriteLine("Enter BOOK'S Author which you want add:");
            book1.FullName = Console.ReadLine();
            System.Console.WriteLine("Enter BOOK'S ISBN which you want add:");
            book1.Isbn = Convert.ToInt64(Console.ReadLine());
            book1.Name = Console.ReadLine();
            System.Console.WriteLine("Enter BOOK'S Dostup which you want add:");
            book1.Dostup = Convert.ToBoolean(Console.ReadLine());
            System.Console.WriteLine("This Book succesfully aded for tables of BOOKS");
            BookServices.AddBook(book1);
            break;
        case "Exist":
        case "exist":
        case "EXIST":
            return 0;
    }
}*/

  foreach (var item in BookServices.GetBooks())
            {
              
                System.Console.Write($"| {item.Id}");
                System.Console.Write($" | {item.Title}");
                System.Console.Write($" | {item.FullName}");
                System.Console.Write($"| {item.Isbn}");
                System.Console.Write($" | {item.Name}");
                System.Console.Write($"| {item.Dostup} |\n");
            }
            
  