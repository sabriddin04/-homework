using Domain.Models;
using Npgsql;
using Dapper;

namespace Infrastructure.Services;

public class BookService : IBookService
{
   private string connect = "Host=localhost;Port=5432;Database=BigLibraryDb; User id=postgres;Password=sabriddin2004";
    public void AddBook(Books book)
    {
         using var connected = new NpgsqlConnection(connect);

         connected.Execute("insert into Books (Title,Isbn,Dostup) values(@Title,@Isbn,@Dostup)",new{Books=book});
    }

    public void DeleteBook(int id)
    {
        using var connected = new NpgsqlConnection(connect);

        connected.Execute("delete from Books where id=@id",new{Id=id});

    }
    public List<Books> GetBooks()
    {
        using var connected = new NpgsqlConnection(connect);
        
        return connected.Query<Books>("select  Books.id,Books.Title,Books.Isbn,Books.Dostup,Authors.FullName,Genre.Name  from Books join Authors_Book on Books.id=Authors_Book.Book_id join Authors on Authors.id=Authors_Book.Author_id join Books_Genre on Authors_Book.Book_id=Books_Genre.Book_id join Genre on Books_Genre.Ganre_id=Genre.id order by id").ToList();
    }

    public void UpdateBook(Books book)
    {
         using var connected = new NpgsqlConnection(connect);
        connected.Execute("Update Books set Title=@title,Isbn=@Isbn,Dostup=@Dostup where id=@id",new{Books=book});        
    }




}
