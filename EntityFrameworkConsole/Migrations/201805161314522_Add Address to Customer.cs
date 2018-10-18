namespace EntityFrameworkConsole.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAddresstoCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Address", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String());
            DropColumn("dbo.Customers", "Address");
        }
    }
}
