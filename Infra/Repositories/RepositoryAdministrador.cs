using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;
using System;
using System.Linq;

namespace Infra.Repositories
{
    public class RepositoryAdministrador : Repository<Administrador>, IRepositoryAdministrador
    {
        public RepositoryAdministrador(ProjectContext _context) : base(_context) { }

        public Administrador ObterPorId(Guid id)
        {
            return _context.Administradores.Include("Usuario").Where(a => a.Id == id).FirstOrDefault();
        }
    }
}