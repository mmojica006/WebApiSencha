namespace webApi1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Sprint1_20190925 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contactoes", "Correo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contactoes", "Correo");
        }
    }
}
