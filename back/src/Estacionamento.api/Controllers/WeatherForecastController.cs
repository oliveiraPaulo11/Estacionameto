using Estacionamento.api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Estacionamento.api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CarroController : ControllerBase
{
    
    public IEnumerable<Veiculo> _veiculo = new Veiculo[]
        {
            new Veiculo{
            VeiculoId = 1,
            TipoVeiculo = TipoVeiculo.Carro,
            PlacaDoCarro = "KKQ-2A66",
            HoraEntrada = DateTime.Now.ToString(),
            HoraSaida = DateTime.Now.AddHours(3).ToString()
            },
            new Veiculo{
            VeiculoId = 2,
            TipoVeiculo = TipoVeiculo.moto,
            PlacaDoCarro = "PCN-3466",
            HoraEntrada = DateTime.Now.ToString(),
            HoraSaida = DateTime.Now.AddHours(2).ToString()
            }
        };
    public CarroController()
    {
       
    }

    [HttpGet]
    public IEnumerable<Veiculo> Get()
    {
        return _veiculo;

    }
    [HttpGet("{id}")]
    public IEnumerable<Veiculo> GetById(int id)
    {
        return _veiculo.Where(Veiculo => Veiculo.VeiculoId == id);

    }
     [HttpPost]
    public string Post()
    {
        return "exemplo de post";
    }

     [HttpPut("{id}")]
    public string Put( int id)
    {
        return $"exemplo de put com id = {id}";
    }

    [HttpDelete("{id}")]
    public string Delete( int id)
    {
        return $"exemplo de Delete com id = {id}";
    }
}
