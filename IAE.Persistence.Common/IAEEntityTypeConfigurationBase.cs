using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAE.Persistence.Entity.Common
{
    public abstract class IAEEntityTypeConfigurationBase<TEntity> : EntityTypeConfiguration<TEntity> where TEntity : class
    {

        public IAEEntityTypeConfigurationBase()
        {
            ConfigurarNomeTabela();
            ConfigurarCamposTabela();
            ConfigurarChavePrimaria();
            ConfigurarChaveEstrangeira();
            ConfigurarOutrasCoisas();
        }


        public abstract void ConfigurarNomeTabela();

        public abstract void ConfigurarCamposTabela();

        public abstract void ConfigurarChavePrimaria();

        public abstract void ConfigurarChaveEstrangeira();

        public abstract void ConfigurarOutrasCoisas();


    }
}
