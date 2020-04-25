﻿using Domain.Entities;
using Domain.Interfaces.Uow;
using Ninject;
using System.Collections.Generic;
using System.Linq;

namespace App.Controllers
{
    public class ExamesController
    {
        private readonly IUnitOfWork _unitOfWork;

        [Inject()]
        public ExamesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Cadastrar(Exame exame)
        {
            _unitOfWork.RepositoryExame.Adicionar(exame);
            _unitOfWork.Commit();
        }

        public IEnumerable<Exame> ObterTodos()
        {
            return _unitOfWork.RepositoryExame.ObterTodos();
        }

        public Exame ObterPorId(int id)
        {
            return _unitOfWork.RepositoryExame.ObterPorId(id);
        }

        public bool AlterarDescricao(int id, string novaDescricao)
        {
            var exame = ObterPorId(id);

            if (exame != null)
            {
                exame.Atualizar(novaDescricao);
                _unitOfWork.RepositoryExame.Atualizar(exame);
                _unitOfWork.Commit();
                return true;
            }
            return false;
        }

        public bool Excluir(int id)
        {
            var exame = ObterPorId(id);

            if (exame != null)
            {
                _unitOfWork.RepositoryExame.Remover(exame);
                _unitOfWork.Commit();
                return true;
            }
            return false;
        }
    }
}
