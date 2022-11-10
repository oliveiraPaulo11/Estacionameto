using Estacionamento.api.Data;
using Estacionamento.api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Estacionamento.api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VeiculoController : ControllerBase
{
    
        private readonly DataContext _context;
    public VeiculoController(DataContext context)
    {
            _context = context;
       
    }

    [HttpGet]
    public IEnumerable<Veiculo> Get()
    {
        return _context.Veiculos;

    }
    [HttpGet("{id}")]
    public Veiculo GetById(int id)
    {
        return _context.Veiculos.FirstOrDefault(Veiculo => Veiculo.VeiculoId == id);

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
