﻿using Ninject;
using Ninject.Parameters;
using ProjetoBase.Vs2012.Dominio.Lib;

namespace ProjetoBase.Vs2012.Infra
{
    public class Fabrica
    {
        private static Fabrica _fInstancia;

        public static Fabrica Instancia
        {
            get { return _fInstancia ?? (_fInstancia = new Fabrica()); }
        }

 
        private StandardKernel Kernel { get; set; }

        protected Fabrica()
        {
           
            var persistencia = new Modulo();            
            this.Kernel = new StandardKernel(persistencia);
        }

       
        public T Obter<T>()
        {
            return this.Kernel.Get<T>();
        }

        public T Obter<T>(IUnidadeDeTrabalho unidadeTrabalho)
        {
            return this.Kernel.Get<T>(new ConstructorArgument("unidadeDeTrabalho", unidadeTrabalho));
        }

    }
}
