namespace BlogMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Menuupdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Text", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Menus", "Name", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Menus", "IsActive", c => c.Boolean(nullable: false));
            DropColumn("dbo.Categories", "Name");
            DropColumn("dbo.Menus", "Text");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Menus", "Text", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Categories", "Name", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Menus", "IsActive");
            DropColumn("dbo.Menus", "Name");
            DropColumn("dbo.Categories", "Text");
        }
    }
}
