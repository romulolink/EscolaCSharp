using IAE.Escola.Dominio;
using IAE.Persistence.Entity.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAE.Escola.Persistencia.Entity.TypeConfigurations
{
    class TurmaTypeConfiguration : IAEEntityTypeConfigurationBase<Turma>
    {
        public override void ConfigurarCamposTabela()
        {
            Property(p => p.Id)
                .HasColumnOrder(0)
                .HasColumnName("TRM_ID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(p => p.Nome)
                .HasColumnOrder(1)
                .HasColumnName("TRM_NOME")
                .HasMaxLength(20)
                .IsRequired();

            Property(p => p.IsAtivo)
                .HasColumnOrder(2)
                .HasColumnName("TRM_ATIVO")
                .IsRequired();


        }

        public override void ConfigurarChaveEstrangeira()
        {
            HasMany(p => p.Alunos)
                .WithOptional(p => p.Turma)
                .HasForeignKey(fk => fk.TurmaId);

            /* Many-Many Example
            HasMany(p => p.Alunos)
                .WithMany(p => p.Turma)
                .Map(m =>
                {
                    m.MapLeftKey("TUR_ID");
                    m.MapRightKey("TUR_ID");
                    m.ToTable("TURMAS_ALUNOS");

                }); */
        }

        public override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.Id);
        }

        public override void ConfigurarNomeTabela()
        {
            ToTable("TRM_TURMAS");
        }

        public override void ConfigurarOutrasCoisas()
        {

        }
    }
}
