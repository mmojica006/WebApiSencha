namespace webApi1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Sprint3_001 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contactoes", "Nombre", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contactoes", "Nombre", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
