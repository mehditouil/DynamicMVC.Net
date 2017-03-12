namespace OrderEntryDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerRegions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        CustomerRegionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CustomerRegions", t => t.CustomerRegionId, cascadeDelete: true)
                .Index(t => t.CustomerRegionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "CustomerRegionId", "dbo.CustomerRegions");
            DropIndex("dbo.Customers", new[] { "CustomerRegionId" });
            DropTable("dbo.Customers");
            DropTable("dbo.CustomerRegions");
        }
    }
}
