using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Core.Domain.Books;

namespace Nop.Services.BooksService;
public partial interface IBooksService
{
    IList<Books> GetAllBooks(string name = null);
    Books GetBookById(int id);
    void InsertBook(Books book);
    void UpdateBook(Books book);
    void DeleteBook(Books book);
}
