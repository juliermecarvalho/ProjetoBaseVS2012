using ProjetoBase.Vs2012.Dominio.Entidades.Base;
using ProjetoBase.Vs2012.Dominio.Enumerados;

namespace ProjetoBase.Vs2012.Dominio.Entidades
{
    public class Pessoa: Entidade
    {
        public string Nome { get; set; }
        public Sexo Sexo { get; set; }

    }
}
