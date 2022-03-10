namespace BirthdayBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixsirname : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BirthInfoes", "Sirname", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BirthInfoes", "Sirname", c => c.Int(nullable: false));
        }
    }
}
