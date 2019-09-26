namespace webApi1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Sprint3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contactoes", "Activo", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contactoes", "Activo");
        }
    }
}
