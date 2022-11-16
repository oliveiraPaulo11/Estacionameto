using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estacionamento.Domain;

namespace Estacionamento.Persistence.Contratos
{
    public interface iVeiculoPersist
    {
        Task<Veiculo[]> getAllVeiculosByPlacaAsync(string placaDoVeiculo);
        Task<Veiculo[]> getAllVeiculosAsync();
        Task<Veiculo> getVeiculoByIdAsync(int veiculoId);
    }
}