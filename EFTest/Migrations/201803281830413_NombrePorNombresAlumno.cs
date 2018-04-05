namespace EFTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NombrePorNombresAlumno : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.Alumnos", "Nombre", "Nombres");
        }
        
        public override void Down()
        {
            RenameColumn("dbo.Alumnos", "Nombres", "Nombre");
        }
    }
}
