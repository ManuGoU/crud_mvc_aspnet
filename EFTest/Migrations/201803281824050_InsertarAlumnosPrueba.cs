namespace EFTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertarAlumnosPrueba : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Alumnos values ('Edison', 'Armando')");
            Sql("Insert into Alumnos values ('Alberto', 'Palmer')");
            Sql("Insert into Alumnos values ('Dayana', 'Pulido')");
        }
        
        public override void Down()
        {
        }
    }
}
