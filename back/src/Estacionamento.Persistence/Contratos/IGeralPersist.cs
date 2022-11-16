using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estacionamento.Domain;

namespace Estacionamento.Persistence.Contratos
{
    public interface iGeralPersist
    {
        void add<T>(T entity) where T: class;
        void update<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;
        void DeleteRanger<T>(T[] entity) where T: class;
        Task<bool> SaveChangesAsync();
    }
}