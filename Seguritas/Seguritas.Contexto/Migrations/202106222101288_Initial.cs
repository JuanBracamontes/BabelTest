namespace Seguritas.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 200),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaModificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Plan",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 200),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaModificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cobertura",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 200),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaModificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlanRelCoberturas",
                c => new
                    {
                        PlanId = c.Int(nullable: false),
                        CoberturaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PlanId, t.CoberturaId })
                .ForeignKey("dbo.Plan", t => t.PlanId, cascadeDelete: true)
                .ForeignKey("dbo.Cobertura", t => t.CoberturaId, cascadeDelete: true)
                .Index(t => t.PlanId)
                .Index(t => t.CoberturaId);
            
            CreateTable(
                "dbo.ClienteRelPlan",
                c => new
                    {
                        ClienteId = c.Int(nullable: false),
                        PlanId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ClienteId, t.PlanId })
                .ForeignKey("dbo.Cliente", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Plan", t => t.PlanId, cascadeDelete: true)
                .Index(t => t.ClienteId)
                .Index(t => t.PlanId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClienteRelPlan", "PlanId", "dbo.Plan");
            DropForeignKey("dbo.ClienteRelPlan", "ClienteId", "dbo.Cliente");
            DropForeignKey("dbo.PlanRelCoberturas", "CoberturaId", "dbo.Cobertura");
            DropForeignKey("dbo.PlanRelCoberturas", "PlanId", "dbo.Plan");
            DropIndex("dbo.ClienteRelPlan", new[] { "PlanId" });
            DropIndex("dbo.ClienteRelPlan", new[] { "ClienteId" });
            DropIndex("dbo.PlanRelCoberturas", new[] { "CoberturaId" });
            DropIndex("dbo.PlanRelCoberturas", new[] { "PlanId" });
            DropTable("dbo.ClienteRelPlan");
            DropTable("dbo.PlanRelCoberturas");
            DropTable("dbo.Cobertura");
            DropTable("dbo.Plan");
            DropTable("dbo.Cliente");
        }
    }
}
