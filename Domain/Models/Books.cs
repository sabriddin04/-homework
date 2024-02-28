using System.Numerics;

namespace Domain.Models;

public class Books
{
 
   public int Id { get; set; }

   public string Title{ get; set; }

   public BigInteger Isbn { get; set; }

   public Boolean Dostup { get; set; }

   public string FullName { get; set; }

   public string Name { get; set; }

}

