namespace EFTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreandoTablaAlumno : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumnoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellidos = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Alumnoes");
        }
    }
}
