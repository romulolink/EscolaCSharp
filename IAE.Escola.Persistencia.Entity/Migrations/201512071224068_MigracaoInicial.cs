namespace IAE.Escola.Persistencia.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigracaoInicial : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ALN_ALUNOS");
            AlterColumn("dbo.ALN_ALUNOS", "ALN_ID", c => c.Long(nullable: false, identity: true));
            AddPrimaryKey("dbo.ALN_ALUNOS", "ALN_ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.ALN_ALUNOS");
            AlterColumn("dbo.ALN_ALUNOS", "ALN_ID", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.ALN_ALUNOS", "ALN_ID");
        }
    }
}
