
using SeguritasModel.Entidades;
using System.Data.Entity;

namespace Seguritas.Contexto
{
    public class SeguritasContext : DbContext
    {
        public SeguritasContext() : base("Seguritas")
        {
            Database.SetInitializer<SeguritasContext>(new CreateDatabaseIfNotExists<SeguritasContext>());
        }

        public DbSet<Cobertura> Coberturas { get; set; }
        public DbSet<Plan> Planes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ClienteRelPlan> ClienteRelPlanes { get; set; }
        public DbSet<PlanRelCobertura> PlanRelCoberturas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
            //Configure domain classes using modelBuilder here..

         /* modelBuilder.Entity<Cobertura>().HasKey<int>(s => s.Id);
            modelBuilder.Entity<Plan>().HasKey<int>(s => s.Id);
            modelBuilder.Entity<Cliente>().HasKey<int>(s => s.Id);
            modelBuilder.Entity<PlanRelCobertura>().HasKey(s => s.Id);
            modelBuilder.Entity<ClienteRelPlan>().HasKey(s => s.Id);*/
        }

    }
}