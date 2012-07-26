﻿using System.Linq;
using ProjetoBase.Vs2012.Dominio.Entidades.Base;
using ProjetoBase.Vs2012.Dominio.Lib;
using ProjetoBase.Vs2012.Dominio.Repositorios.Base;
using ProjetoBase.Vs2012.Persistencia.Lib;

namespace ProjetoBase.Vs2012.Persistencia.Repositorios.Base
{
    public class Repositorio<TEntidade> : IRepositorio<TEntidade> where TEntidade : Entidade
    {
        private readonly IUnidadeDeTrabalho _unidadeDeTrabalho;

        protected virtual Contexto Contexto
        {
            get { return ((UnidadeDeTrabalho) _unidadeDeTrabalho).Contexto; }
        }

        public Repositorio(IUnidadeDeTrabalho unidadeDeTrabalho)
        {
            _unidadeDeTrabalho = unidadeDeTrabalho;
        }

        public virtual TEntidade Obter(int id)
        {
            return this.Contexto.Set<TEntidade>().Find(id);
        }

        public virtual void Salvar(TEntidade entidade)
        {
            if(entidade.Id == 0)
                this.Contexto.Set<TEntidade>().Add(entidade);
        }

        public virtual void Deletar(int id)
        {
            var entidade = this.Obter(id);
            this.Deletar(entidade);
        }

        public virtual void Deletar(TEntidade entidade)
        {
            this.Contexto.Set<TEntidade>().Remove(entidade);
        }

        public virtual IQueryable<TEntidade> Listar()
        {
            return this.Contexto.Set<TEntidade>();
        }
    }
}
