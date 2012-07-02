using System;


namespace ProjetoBase.Vs2012.Dominio.Lib
{
    public interface IUnidadeDeTrabalho : IDisposable
    {

        void Commit();
    }
}
