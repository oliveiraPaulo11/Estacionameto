using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento.Domain
{
    public class Veiculo
    {
        public int VeiculoId { get; set; }

        public TipoVeiculo TipoVeiculo { get; set; }

        public string PlacaDoVeiculo { get; set; } ="";

        public DateTime? HoraEntrada { get; set; }

        public DateTime? DataEntrada { get; set; } 

        public DateTime? HoraSaida { get; set; } 

        public DateTime? DataSaida { get; set; } 


        public decimal? valorAPagar { get; set; }
    }
}