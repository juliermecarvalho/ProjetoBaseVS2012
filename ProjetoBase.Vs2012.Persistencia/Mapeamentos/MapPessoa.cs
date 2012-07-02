using System.Data.Entity.ModelConfiguration;
using ProjetoBase.Vs2012.Dominio.Entidades;

namespace ProjetoBase.Vs2012.Persistencia.Mapeamentos
{
    class MapPessoa : EntityTypeConfiguration<Pessoa>
    {
        public MapPessoa()
        {
            this.ToTable("Pessoas");
        }
    }
}
