using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estacionamento.Domain;

namespace Estacionamento.Persistence.Contratos
{
    public interface iMensalistaPersist
    {
        Task<Mensalista[]> getAllMensalistaByNomeAsync(string nome);
        Task<Mensalista[]> getAllMensalistasAsync();
        Task<Mensalista> getAllMensalistaIdByAsync(int id);




    }
}