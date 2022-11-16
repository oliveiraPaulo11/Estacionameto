using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estacionamento.Application.contratos;
using Estacionamento.Domain;
using Estacionamento.Persistence.Contratos;

namespace Estacionamento.Application
{
    public class VeiculoService : IVeiculoService
    {
        public iVeiculoPersist VeiculoPersist { get; }
        public iGeralPersist GeralPersist { get; }
        public VeiculoService(iGeralPersist geralPersist, iVeiculoPersist veiculoPersist)
        {
            this.GeralPersist = geralPersist;
            this.VeiculoPersist = veiculoPersist;
            
        }

        public async Task<Veiculo> AddVeiculo(Veiculo model)
        {
            try
            {
                GeralPersist.add<Veiculo>(model);
                if (await GeralPersist.SaveChangesAsync()){
                    return await VeiculoPersist.getVeiculoByIdAsync(model.VeiculoId);
                }
                return null;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        public async Task<Veiculo> UpdateVeiculo(int veiculoId, Veiculo model)
        {
            try
            {
                var veiculo = await VeiculoPersist.getVeiculoByIdAsync(veiculoId);
                if ( veiculo == null) return null;

                model.VeiculoId = veiculo.VeiculoId;

                GeralPersist.update(model);
                if (await GeralPersist.SaveChangesAsync()){
                    return await VeiculoPersist.getVeiculoByIdAsync(model.VeiculoId);
                }
                return null;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeleteVeiculo(int veiculoId)
        {
            try
            {
                var veiculo = await VeiculoPersist.getVeiculoByIdAsync(veiculoId);
                if ( veiculo == null) throw new Exception("Veiculo para deletar não encontrado.");
                GeralPersist.Delete<Veiculo>(veiculo);
                return await GeralPersist.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        public async Task<Veiculo[]> getAllVeiculosAsync()
        {
            try
            {
                var veiculos = await VeiculoPersist.getAllVeiculosAsync();
                if(veiculos == null) return null;

                return veiculos;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        public async Task<Veiculo[]> getAllVeiculosByPlacaAsync(string placaDoVeiculo)
        {
            try
            {
                var veiculos = await VeiculoPersist.getAllVeiculosByPlacaAsync(placaDoVeiculo);
                if(veiculos == null) return null;

                return veiculos;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }        }

        public async Task<Veiculo> getVeiculosIdByAsync(int veiculoId)
        {
            try
            {
                var veiculos = await VeiculoPersist.getVeiculoByIdAsync(veiculoId);
                if(veiculos == null) return null;

                return veiculos;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }
    }
}