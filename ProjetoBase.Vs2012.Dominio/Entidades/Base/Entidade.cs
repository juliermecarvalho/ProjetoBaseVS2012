using System;

namespace ProjetoBase.Vs2012.Dominio.Entidades.Base
{
    [Serializable]
    public class Entidade : IEntidade
    {
        public virtual int Id { get; set; }
    }
}
