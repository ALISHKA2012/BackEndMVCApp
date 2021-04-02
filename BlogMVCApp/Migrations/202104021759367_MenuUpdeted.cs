namespace BlogMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MenuUpdeted : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Menus", "ActionName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Menus", "ActionName", c => c.String(nullable: false));
        }
    }
}
