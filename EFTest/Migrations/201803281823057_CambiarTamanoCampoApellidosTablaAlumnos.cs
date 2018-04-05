namespace EFTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambiarTamanoCampoApellidosTablaAlumnos : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Alumnos", "Apellidos", c => c.String(maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Alumnos", "Apellidos", c => c.String(maxLength: 50, unicode: false));
        }
    }
}
