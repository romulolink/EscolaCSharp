namespace IAE.Escola.Persistencia.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicaoTelefone : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Alunoes", "Telefone", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Alunoes", "Telefone");
        }
    }
}
