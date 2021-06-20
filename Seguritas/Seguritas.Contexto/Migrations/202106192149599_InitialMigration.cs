namespace Seguritas.Contexto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClienteRelPlan",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClienteId = c.Int(nullable: false),
                        PlanId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cliente", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Plan", t => t.PlanId, cascadeDelete: true)
                .Index(t => t.ClienteId)
                .Index(t => t.PlanId);
            
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
                "dbo.PlanRelCobertura",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CoberturaId = c.Int(nullable: false),
                        PlanId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cobertura", t => t.CoberturaId, cascadeDelete: true)
                .ForeignKey("dbo.Plan", t => t.PlanId, cascadeDelete: true)
                .Index(t => t.CoberturaId)
                .Index(t => t.PlanId);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlanRelCobertura", "PlanId", "dbo.Plan");
            DropForeignKey("dbo.ClienteRelPlan", "PlanId", "dbo.Plan");
            DropForeignKey("dbo.PlanRelCobertura", "CoberturaId", "dbo.Cobertura");
            DropForeignKey("dbo.ClienteRelPlan", "ClienteId", "dbo.Cliente");
            DropIndex("dbo.PlanRelCobertura", new[] { "PlanId" });
            DropIndex("dbo.PlanRelCobertura", new[] { "CoberturaId" });
            DropIndex("dbo.ClienteRelPlan", new[] { "PlanId" });
            DropIndex("dbo.ClienteRelPlan", new[] { "ClienteId" });
            DropTable("dbo.Plan");
            DropTable("dbo.PlanRelCobertura");
            DropTable("dbo.Cobertura");
            DropTable("dbo.Cliente");
            DropTable("dbo.ClienteRelPlan");
        }
    }
}
