namespace BusReservations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BusCompanies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Destinations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        From = c.String(),
                        To = c.String(),
                        Price = c.Int(nullable: false),
                        Distance = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DestinationBusCompanies",
                c => new
                    {
                        Destination_Id = c.Int(nullable: false),
                        BusCompany_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Destination_Id, t.BusCompany_Id })
                .ForeignKey("dbo.Destinations", t => t.Destination_Id, cascadeDelete: true)
                .ForeignKey("dbo.BusCompanies", t => t.BusCompany_Id, cascadeDelete: true)
                .Index(t => t.Destination_Id)
                .Index(t => t.BusCompany_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DestinationBusCompanies", "BusCompany_Id", "dbo.BusCompanies");
            DropForeignKey("dbo.DestinationBusCompanies", "Destination_Id", "dbo.Destinations");
            DropIndex("dbo.DestinationBusCompanies", new[] { "BusCompany_Id" });
            DropIndex("dbo.DestinationBusCompanies", new[] { "Destination_Id" });
            DropTable("dbo.DestinationBusCompanies");
            DropTable("dbo.Destinations");
            DropTable("dbo.BusCompanies");
        }
    }
}
