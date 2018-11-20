namespace Cellular.MainDal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Calls",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LineID = c.Int(nullable: false),
                        Duration = c.Time(nullable: false, precision: 7),
                        DestinationNumber = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Lines", t => t.LineID, cascadeDelete: true)
                .Index(t => t.LineID);
            
            CreateTable(
                "dbo.Lines",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ClientID = c.Int(nullable: false),
                        Number = c.String(nullable: false),
                        PackageID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Clients", t => t.ClientID, cascadeDelete: true)
                .ForeignKey("dbo.Packages", t => t.PackageID, cascadeDelete: true)
                .Index(t => t.ClientID)
                .Index(t => t.PackageID);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        ClientTypeID = c.Int(nullable: false),
                        Password = c.String(maxLength: 15),
                        FisrtName = c.String(name: "Fisrt Name", maxLength: 15),
                        LastName = c.String(name: "Last Name", maxLength: 15),
                        EmailAddress = c.String(name: "Email Address"),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Client Type", t => t.ClientTypeID, cascadeDelete: true)
                .Index(t => t.ClientTypeID);
            
            CreateTable(
                "dbo.Client Type",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        CallMinutePrice = c.Single(name: "Call Minute Price", nullable: false),
                        SMSPrice = c.Single(name: "SMS Price", nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Packages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PackageIncluds",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Price = c.Single(nullable: false),
                        PackageID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Packages", t => t.PackageID, cascadeDelete: true)
                .Index(t => t.PackageID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Password = c.String(maxLength: 15),
                        FisrtName = c.String(name: "Fisrt Name", maxLength: 15),
                        LastName = c.String(name: "Last Name", maxLength: 15),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        TotalPrice = c.Single(nullable: false),
                        Month = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.RegisrationDetails",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false),
                        ClientID = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.EmployeeID, t.ClientID })
                .ForeignKey("dbo.Clients", t => t.ClientID, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeID, cascadeDelete: true)
                .Index(t => t.EmployeeID)
                .Index(t => t.ClientID);
            
            CreateTable(
                "dbo.SMS",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LineID = c.Int(nullable: false),
                        DestinationNumber = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Lines", t => t.LineID, cascadeDelete: true)
                .Index(t => t.LineID);
            
            CreateTable(
                "dbo.FriendsDiacounts",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Number1 = c.String(),
                        Number2 = c.String(),
                        Number3 = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PackageIncluds", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.MinutesBanks",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        MaxMinutes = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PackageIncluds", t => t.ID)
                .Index(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MinutesBanks", "ID", "dbo.PackageIncluds");
            DropForeignKey("dbo.FriendsDiacounts", "ID", "dbo.PackageIncluds");
            DropForeignKey("dbo.SMS", "LineID", "dbo.Lines");
            DropForeignKey("dbo.RegisrationDetails", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.RegisrationDetails", "ClientID", "dbo.Clients");
            DropForeignKey("dbo.Payments", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Calls", "LineID", "dbo.Lines");
            DropForeignKey("dbo.Lines", "PackageID", "dbo.Packages");
            DropForeignKey("dbo.PackageIncluds", "PackageID", "dbo.Packages");
            DropForeignKey("dbo.Lines", "ClientID", "dbo.Clients");
            DropForeignKey("dbo.Clients", "ClientTypeID", "dbo.Client Type");
            DropIndex("dbo.MinutesBanks", new[] { "ID" });
            DropIndex("dbo.FriendsDiacounts", new[] { "ID" });
            DropIndex("dbo.SMS", new[] { "LineID" });
            DropIndex("dbo.RegisrationDetails", new[] { "ClientID" });
            DropIndex("dbo.RegisrationDetails", new[] { "EmployeeID" });
            DropIndex("dbo.Payments", new[] { "ClientId" });
            DropIndex("dbo.PackageIncluds", new[] { "PackageID" });
            DropIndex("dbo.Clients", new[] { "ClientTypeID" });
            DropIndex("dbo.Lines", new[] { "PackageID" });
            DropIndex("dbo.Lines", new[] { "ClientID" });
            DropIndex("dbo.Calls", new[] { "LineID" });
            DropTable("dbo.MinutesBanks");
            DropTable("dbo.FriendsDiacounts");
            DropTable("dbo.SMS");
            DropTable("dbo.RegisrationDetails");
            DropTable("dbo.Payments");
            DropTable("dbo.Employees");
            DropTable("dbo.PackageIncluds");
            DropTable("dbo.Packages");
            DropTable("dbo.Client Type");
            DropTable("dbo.Clients");
            DropTable("dbo.Lines");
            DropTable("dbo.Calls");
        }
    }
}
