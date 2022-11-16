using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estacionamento.Domain;
using Estacionamento.Persistence.Contextos;
using Estacionamento.Persistence.Contratos;
using Microsoft.EntityFrameworkCore;

namespace Estacionamento.Persistence
{
    public class GeralPersist : iGeralPersist
    {
        public readonly EstacionamentoContext _context;

        public GeralPersist(EstacionamentoContext context)
        {
            this._context = context;
            
        }

        public void add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void DeleteRanger<T>(T[] entityArry) where T : class
        {
            _context.RemoveRange(entityArry);
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync())> 0;
        }
    }
}