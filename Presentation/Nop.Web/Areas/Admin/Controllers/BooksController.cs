using Microsoft.AspNetCore.Mvc;
using Nop.Core.Domain.Books;
using Nop.Services.BooksService;
using Nop.Web.Areas.Admin.Infrastructure.Mapper.Extensions;
using Nop.Web.Areas.Admin.Models.Books;

namespace Nop.Web.Areas.Admin.Controllers;
public class BooksController : BaseAdminController
{
    #region fields
    private readonly IBooksService _booksService;
    #endregion

    #region ctor
    public BooksController(IBooksService booksService)
    {
        _booksService = booksService;
    }
    #endregion
    #region Methods
    public IActionResult List()
        {
            var books = _booksService.GetAllBooks();
            var model = books.Select(b => b.ToModel<BooksModel>()).ToList();
            return View(model);
        }

        public IActionResult Create()
        {
            return View(new BooksModel());
        }

        [HttpPost]
        public IActionResult Create(BooksModel model)
        {
            if (!ModelState.IsValid) return View(model);
            var book = model.ToEntity<Books>();
            _booksService.InsertBook(book);
            return RedirectToAction("List");
        }

        public IActionResult Edit(int id)
        {
            var book = _booksService.GetBookById(id);
            if (book == null) return NotFound();
            var model = book.ToModel<BooksModel>();
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(BooksModel model)
        {
            if (!ModelState.IsValid) return View(model);
            var book = _booksService.GetBookById(model.Id);
            book.Name = model.Name;
            book.CreatedOn = model.CreatedOn;
            _booksService.UpdateBook(book);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            var book = _booksService.GetBookById(id);
            if (book != null)
                _booksService.DeleteBook(book);
            return RedirectToAction("List");
        }
    #endregion
}
