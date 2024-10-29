using FluentMigrator;
using Nop.Data.Migrations;
using static LinqToDB.Reflection.Methods.LinqToDB;

[NopMigration("2024/10/27 09:36:08:9037677","Nop books ftable0")] // Using NopMigrationAttribute
public class InitialCreateBooks : ForwardOnlyMigration
{
    public override void Up()
    {
        // Create the Books table using Create.Table method
        Create.Table("Books")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("Name").AsString().NotNullable()
            .WithColumn("CreatedOn").AsDateTime().NotNullable();
    }
}
