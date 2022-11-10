using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento.api.Models
{
    public class Veiculo
    {
        public int VeiculoId { get; set; }

        public TipoVeiculo TipoVeiculo { get; set; }

        public string PlacaDoCarro { get; set; } ="";

        public string HoraEntrada { get; set; } ="";

        public string HoraSaida { get; set; } ="";
    }
}