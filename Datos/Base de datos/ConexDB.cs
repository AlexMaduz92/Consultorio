using Datos.Entidades;
using System.Data.Entity;

namespace Datos.Base_de_datos
{
    public class ConexDB : DbContext
    {
        public ConexDB()
        : base("Data Source=DESKTOP-Q6JBD0N\\SQLEXPRESS01;Initial Catalog=CONSULTORIORAD;Persist Security Info=True;User ID=sa;Password=123456789;MultipleActiveResultSets=True")
        {
        }

        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Cita> Citas { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cita>()
                .HasRequired(c => c.Medico)
                .WithMany()
                .HasForeignKey(c => c.MedicoId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cita>()
                .HasRequired(c => c.Paciente)
                .WithMany()
                .HasForeignKey(c => c.PacienteId)
                .WillCascadeOnDelete(false);
        }
    }
}
