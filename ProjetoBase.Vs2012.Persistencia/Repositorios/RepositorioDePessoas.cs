using ProjetoBase.Vs2012.Dominio.Entidades;
using ProjetoBase.Vs2012.Dominio.Lib;
using ProjetoBase.Vs2012.Dominio.Repositorios;
using ProjetoBase.Vs2012.Persistencia.Repositorios.Base;

namespace ProjetoBase.Vs2012.Persistencia.Repositorios
{
    public class RepositorioDePessoas :  Repositorio<Pessoa>, IRepositorioDePessoas
    {
        public RepositorioDePessoas(IUnidadeDeTrabalho unidadeDeTrabalho):base(unidadeDeTrabalho)
        {

        }
    }
}
