namespace IAE.Escola.Persistencia.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigracaoInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ALN_ALUNOS",
                c => new
                    {
                        ALN_ID = c.Long(nullable: false, identity: true),
                        ALN_NOME = c.String(nullable: false, maxLength: 200),
                        ALN_MATRICULA = c.Int(nullable: false),
                        ALN_DATA_NASCIMENTO = c.DateTime(nullable: false),
                        ALN_EMAIL = c.String(),
                        ALN_TELEFONE = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.ALN_ID);
            
            CreateTable(
                "dbo.CRS_CURSOS",
                c => new
                    {
                        CRS_ID = c.Long(nullable: false, identity: true),
                        CRS_NOME = c.String(nullable: false, maxLength: 50),
                        CRL_EMENTA = c.String(nullable: false, maxLength: 500),
                        CRS_CARGA_HORARIA = c.Int(nullable: false),
                        CRS_ATIVO = c.Boolean(),
                    })
                .PrimaryKey(t => t.CRS_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CRS_CURSOS");
            DropTable("dbo.ALN_ALUNOS");
        }
    }
}
