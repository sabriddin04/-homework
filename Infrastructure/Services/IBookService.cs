using Domain.Models;

namespace Infrastructure.Services;

public interface IBookService
{
   List<Books>GetBooks();

   void AddBook(Books book);

   void UpdateBook(Books book);

   void DeleteBook(int id);


   
}
