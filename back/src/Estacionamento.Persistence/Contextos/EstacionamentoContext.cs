using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estacionamento.Domain;
using Microsoft.EntityFrameworkCore;

namespace Estacionamento.Persistence.Contextos
{
    public class EstacionamentoContext : DbContext
    {
        public EstacionamentoContext(DbContextOptions<EstacionamentoContext> options) : base(options) { }

        public DbSet<Veiculo>? Veiculos { get; set; }

        public DbSet<Mensalista>? Mensalistas { get; set; }
    }
}