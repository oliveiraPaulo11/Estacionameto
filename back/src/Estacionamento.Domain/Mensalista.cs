using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento.Domain
{
    public class Mensalista
    {
        public int Id { get; set; }
        public string Nome { get; set; } ="";
        public string Placa { get; set; } ="";
        public TipoVeiculo Veiculo { get; set; }
        public int Celular { get; set; }
        public string NomeVeiculo { get; set; }  ="";
        public string Cor { get; set; } ="";
        public string Turno { get; set; } ="";
    }
}