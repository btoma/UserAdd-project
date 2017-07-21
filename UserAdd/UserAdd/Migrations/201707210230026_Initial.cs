namespace UserAdd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ADDUSER",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FIRSTNAME = c.String(),
                        LASTNAME = c.String(),
                        PHONENUMBER = c.String(),
                        EMAIL = c.String(),
                        ADDRESSES = c.String(),
                        PROFILIMAGE = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ADDUSER");
        }
    }
}
