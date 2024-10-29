using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Web.Areas.Admin.Models.Books;

public partial record BooksModel : BaseNopEntityModel
{
    [NopResourceDisplayName("Admin.Books.Fields.Name")]
    public string Name { get; set; }

    [NopResourceDisplayName("Admin.Books.Fields.CreatedOn")]
    public DateTime CreatedOn { get; set; }
}
