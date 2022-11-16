using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estacionamento.Domain;

namespace Estacionamento.Application.contratos
{
    public interface IVeiculoService
    {
        Task<Veiculo> AddVeiculo(Veiculo model);
        Task<Veiculo> UpdateVeiculo( int veiculoId ,Veiculo model);
        Task<bool> DeleteVeiculo(int veiculoId);

        Task<Veiculo[]> getAllVeiculosAsync();
        Task<Veiculo[]> getAllVeiculosByPlacaAsync(string PlacaDoVeiculo);
        Task<Veiculo> getVeiculosIdByAsync(int VeiculoId);
    }
}