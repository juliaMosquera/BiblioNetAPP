using BiblioNetAPP.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BiblioNetAPP.Services
{

    public interface IRepositorieBook
    {
        void Create(Book book);
    }
    public class RepositorieBook : IRepositorieBook
    {
        private readonly string connectionString;

        public RepositorieBook(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void Create(Book book)
        {

            //Microsoft.Data.SqlClient;
            using var connection = new SqlConnection(connectionString);
            //Dapper
            var id = connection.QuerySingle<int>($@"Insert into Book
                                                (BookName, IdAuthor, Price) 
                                                VALUES (@BookName, @IdAuthor, @Price); SELECT SCOPE_IDENTITY();",book);
            book.Id = id;
        }
    }
}
