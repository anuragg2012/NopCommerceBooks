using System.Data.Entity.ModelConfiguration;
using FluentMigrator.Builders.Create.Table;
using Nop.Core.Domain.Blogs;
using Nop.Core.Domain.Books;
using Nop.Core.Domain.Localization;
using Nop.Data.Mapping.Builders;

namespace Nop.Data.Mapping.Builders.BooksBuilder;
public class BooksMap : NopEntityBuilder<Books>
{
    #region Methods

    /// <summary>
    /// Apply entity configuration
    /// </summary>
    /// <param name="table">Create table expression builder</param>
    public override void MapEntity(CreateTableExpressionBuilder table)
    {
        table
            .WithColumn(nameof(Books.Id)).AsString(int.MaxValue).NotNullable()
            .WithColumn(nameof(Books.Name)).AsString(255).NotNullable()
            .WithColumn(nameof(Books.CreatedOn)).AsDateTime().NotNullable();
    }

    #endregion
}
