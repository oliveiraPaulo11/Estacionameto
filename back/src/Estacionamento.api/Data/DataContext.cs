using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estacionamento.api.Models;
using Microsoft.EntityFrameworkCore;

namespace Estacionamento.api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Veiculo>? Veiculos { get; set; }
    }
}