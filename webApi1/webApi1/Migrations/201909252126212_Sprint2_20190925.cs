namespace webApi1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Sprint2_20190925 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contactoes", "Telefono", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contactoes", "Telefono");
        }
    }
}
