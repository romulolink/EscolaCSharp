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
    internal class CursoTypeConfiguration : IAEEntityTypeConfigurationBase<Curso>
    {
        public override void ConfigurarCamposTabela()
        {
            Property(p => p.Id)
               .HasColumnOrder(0)
               .HasColumnName("CRS_ID")
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
               .IsRequired();
            Property(p => p.Nome)
                .HasColumnOrder(1)
                .HasColumnName("CRS_NOME")
                .HasMaxLength(50)
                .IsRequired();
            Property(p => p.Ementa)
                .HasColumnOrder(2)
                .HasMaxLength(500)
                .HasColumnName("CRL_EMENTA")
                .IsRequired();
            Property(p => p.CargaHoraria)
                .HasColumnOrder(3)
                .HasColumnName("CRS_CARGA_HORARIA")
                .IsRequired();
            Property(p => p.isAtivo)
                .HasColumnOrder(4)
                .HasColumnName("CRS_ATIVO")
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
            ToTable("CRS_CURSOS");
        }

        public override void ConfigurarOutrasCoisas()
        {
           
        }
    }
}
