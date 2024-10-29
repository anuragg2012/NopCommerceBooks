using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Core.Domain.Books;
using Nop.Data;

namespace Nop.Services.BooksService;
public partial class BooksService:IBooksService
{
    private readonly IRepository<Books> _booksRepository;

    public BooksService(IRepository<Books> booksRepository)
    {
        _booksRepository = booksRepository;
    }

    public IList<Books> GetAllBooks(string name = null)
    {
        var query = _booksRepository.GetAll();
        if (!string.IsNullOrEmpty(name))
            query = query.Where(b => b.Name.Contains(name)).ToList();
        return query.ToList();
    }

    public Books GetBookById(int id) => _booksRepository.GetById(id);

    public void InsertBook(Books book) => _booksRepository.Insert(book);

    public void UpdateBook(Books book) => _booksRepository.Update(book);

    public void DeleteBook(Books book) => _booksRepository.Delete(book);
}

