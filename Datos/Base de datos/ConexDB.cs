using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Datos.Entidades;

namespace Datos.Base_de_datos
{
    internal class ConexDB : DbContext
    {
        public ConexDB() : base("CONSULTORIORAD")
        {
        }

        // Agrega DbSet para cada una de tus entidades (tablas)
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
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
