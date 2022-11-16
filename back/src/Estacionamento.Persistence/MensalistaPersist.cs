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
    public class MensalistaPersist : iMensalistaPersist
    {
        public readonly EstacionamentoContext _context;

        public MensalistaPersist(EstacionamentoContext context)
        {
            this._context = context;
            // _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

        }

       
        public async Task<Mensalista[]> getAllMensalistasAsync()
        {
            IQueryable<Mensalista> query = _context.Mensalistas;
            query = query.AsNoTracking().OrderBy(m => m.Id);

            return await query.ToArrayAsync();
        }
        public async Task<Mensalista[]> getAllMensalistaByNomeAsync(string nome)
        {
            IQueryable<Mensalista> query = _context.Mensalistas;
            query  = query.AsNoTracking().OrderBy(m => m.Id).Where(m => m.Nome.ToLower().Contains(nome.ToLower()));

            return await query.ToArrayAsync();
        }

        public async Task<Mensalista> getAllMensalistaIdByAsync(int Id)
        {
             IQueryable<Mensalista> query = _context.Mensalistas;
            query = query.AsNoTracking().OrderBy(m => m.Id).Where(m => m.Id == Id);

            return await query.FirstOrDefaultAsync();
        }





    }
}