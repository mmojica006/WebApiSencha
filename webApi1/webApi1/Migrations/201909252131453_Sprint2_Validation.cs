namespace webApi1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Sprint2_Validation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contactoes", "Nombre", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Contactoes", "Correo", c => c.String(maxLength: 50));
            AlterColumn("dbo.Contactoes", "Telefono", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contactoes", "Telefono", c => c.String());
            AlterColumn("dbo.Contactoes", "Correo", c => c.String());
            AlterColumn("dbo.Contactoes", "Nombre", c => c.String());
        }
    }
}
