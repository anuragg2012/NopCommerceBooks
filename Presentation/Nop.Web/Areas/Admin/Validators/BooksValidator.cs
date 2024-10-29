using FluentValidation;
using Nop.Core.Domain.Books;
using Nop.Services.Localization;
using Nop.Web.Areas.Admin.Models.Books;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Admin.Validators;

public partial class BooksValidator: BaseNopValidator<BooksModel>
{
    public BooksValidator(ILocalizationService localizationService)
    {
        RuleFor(x => x.Name).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.Books.Fields.Name.Required"));
        SetDatabaseValidationRules<Books>();
    }
}
