namespace EFTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambiarNombreTablaAlumnos : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Alumnoes", newName: "Alumnos");
            AlterColumn("dbo.Alumnos", "Nombre", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Alumnos", "Apellidos", c => c.String(maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Alumnos", "Apellidos", c => c.String());
            AlterColumn("dbo.Alumnos", "Nombre", c => c.String());
            RenameTable(name: "dbo.Alumnos", newName: "Alumnoes");
        }
    }
}
