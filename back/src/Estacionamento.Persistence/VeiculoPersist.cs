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
    public class VeiculoPersist : iVeiculoPersist
    {
        public readonly EstacionamentoContext _context;

        public VeiculoPersist(EstacionamentoContext context)
        {
            this._context = context;
            // _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            
        }
        public async Task<Veiculo[]> getAllVeiculosAsync()
        {
            IQueryable<Veiculo> query = _context.Veiculos;
            query = query.AsNoTracking().OrderBy(v => v.VeiculoId);

            return await query.ToArrayAsync();
        }
        public async Task<Veiculo[]> getAllVeiculosByPlacaAsync(string placaDoVeiculo)
        {
            IQueryable<Veiculo> query = _context.Veiculos;
            query = query.AsNoTracking().OrderBy(v => v.VeiculoId).Where(v => v.PlacaDoVeiculo.ToLower().Contains(placaDoVeiculo.ToLower()));

            return await query.ToArrayAsync();
        }

        public async Task<Veiculo> getVeiculoByIdAsync(int veiculoId)
        {
            IQueryable<Veiculo> query = _context.Veiculos;
            query = query.AsNoTracking().OrderBy(v => v.VeiculoId).Where(v => v.VeiculoId == veiculoId);

            return await query.FirstOrDefaultAsync();
        }
       





    }
}