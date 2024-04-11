namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddicionTablaDCita : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Citas",
                c => new
                    {
                        CitaId = c.Int(nullable: false, identity: true),
                        MedicoId = c.Int(nullable: false),
                        PacienteId = c.Int(nullable: false),
                        FechaCita = c.DateTime(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CitaId)
                .ForeignKey("dbo.Medicos", t => t.MedicoId)
                .ForeignKey("dbo.Pacientes", t => t.PacienteId)
                .Index(t => t.MedicoId)
                .Index(t => t.PacienteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Citas", "PacienteId", "dbo.Pacientes");
            DropForeignKey("dbo.Citas", "MedicoId", "dbo.Medicos");
            DropIndex("dbo.Citas", new[] { "PacienteId" });
            DropIndex("dbo.Citas", new[] { "MedicoId" });
            DropTable("dbo.Citas");
        }
    }
}
