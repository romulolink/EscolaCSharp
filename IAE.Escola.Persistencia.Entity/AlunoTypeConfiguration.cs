using IAE.Escola.Dominio;
using IAE.Persistence.Entity.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAE.Escola.Persistencia.Entity
{
    internal class AlunoTypeConfiguration : IAEEntityTypeConfigurationBase<Aluno>
    {
        public override void ConfigurarCamposTabela()
        {
            Property(p => p.Id)
                .HasColumnOrder(0)
                .HasColumnName("ALN_ID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(p => p.Nome)
                .HasColumnOrder(1)
                .HasColumnName("ALN_NOME")
                .HasMaxLength(200)
                .IsRequired();
            Property(p => p.Matricula)
                .HasColumnOrder(2)
                .HasColumnName("ALN_MATRICULA")
                .IsRequired();
            Property(p => p.DataNascimento)
                .HasColumnOrder(3)
                .HasColumnName("ALN_DATA_NASCIMENTO")
                .IsRequired();
            Property(p => p.Email)
                .HasColumnOrder(4)
                .HasColumnName("ALN_EMAIL")
                .IsOptional();
            Property(p => p.Telefone)
                .HasColumnOrder(5)
                .HasColumnName("ALN_TELEFONE")
                .HasMaxLength(15)
                .IsOptional();
        }

        public override void ConfigurarChaveEstrangeira()
        {
     
        }

        public override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.Id);
        }

        public override void ConfigurarNomeTabela()
        {
            ToTable("ALN_ALUNOS");
        }

        public override void ConfigurarOutrasCoisas()
        {
         
        }
    }
}
