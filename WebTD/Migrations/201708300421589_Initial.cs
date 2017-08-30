namespace Login.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Records",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        StageNum = c.Int(nullable: false),
                        Stars = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserName, t.StageNum });
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Name);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Records");
        }
    }
}
