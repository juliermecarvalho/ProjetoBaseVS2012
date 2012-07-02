using Ninject.Modules;
using ProjetoBase.Vs2012.Dominio.Lib;
using ProjetoBase.Vs2012.Dominio.Repositorios;
using ProjetoBase.Vs2012.Persistencia.Lib;
using ProjetoBase.Vs2012.Persistencia.Repositorios;

namespace ProjetoBase.Vs2012.Infra
{
    public class Modulo : NinjectModule
    {
        public override void Load()
        {
            base.Bind<IUnidadeDeTrabalho>().To<UnidadeDeTrabalho>();
            base.Bind<IRepositorioDePessoas>().To<RepositorioDePessoas>();  
        }
    }
}
