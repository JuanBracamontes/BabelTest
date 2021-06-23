
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.HasDefaultSchema("dbo");
            //Configure domain classes using modelBuilder here..
            modelBuilder.Entity<Cliente>()
                .HasMany(t => t.Planes)
                .WithMany(t => t.Clientes)
                .Map(m => { 
                    m.ToTable("ClienteRelPlan");
                    m.MapLeftKey("ClienteId");
                    m.MapRightKey("PlanId");
                });

            modelBuilder.Entity<Plan>()
                .HasMany(t => t.Coberturas)
                .WithMany(t => t.Planes)
                .Map(m => {
                    m.ToTable("PlanRelCoberturas");
                    m.MapLeftKey("PlanId");
                    m.MapRightKey("CoberturaId");
                });
        }

    }
}