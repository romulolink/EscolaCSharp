namespace IAE.Escola.Persistencia.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicaoTurma : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TRM_TURMAS",
                c => new
                    {
                        TRM_ID = c.Int(nullable: false, identity: true),
                        TRM_NOME = c.String(nullable: false, maxLength: 20),
                        TRM_ATIVO = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TRM_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TRM_TURMAS");
        }
    }
}
