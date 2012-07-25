using ProjetoBase.Vs2012.Dominio.Entidades.Base;
using ProjetoBase.Vs2012.Dominio.Enumerados;

namespace ProjetoBase.Vs2012.Dominio.Entidades
{
    public class Pessoa: Entidade
    {
        public virtual string Nome { get; set; }
        public virtual Sexo Sexo { get; set; }

    }
}
