namespace IAE.Escola.Persistencia.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LinkAlunoTurma : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ALN_ALUNOS", "TRM_ID", c => c.Int());
            CreateIndex("dbo.ALN_ALUNOS", "TRM_ID");
            AddForeignKey("dbo.ALN_ALUNOS", "TRM_ID", "dbo.TRM_TURMAS", "TRM_ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ALN_ALUNOS", "TRM_ID", "dbo.TRM_TURMAS");
            DropIndex("dbo.ALN_ALUNOS", new[] { "TRM_ID" });
            DropColumn("dbo.ALN_ALUNOS", "TRM_ID");
        }
    }
}
