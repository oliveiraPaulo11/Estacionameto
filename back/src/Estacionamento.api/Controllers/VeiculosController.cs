using Estacionamento.Persistence;
using Estacionamento.Domain;
using Microsoft.AspNetCore.Mvc;
using Estacionamento.Persistence.Contextos;
using Estacionamento.Application.contratos;

namespace Estacionamento.api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VeiculoController : ControllerBase
{
        public IVeiculoService VeiculoService { get; }
    
    public VeiculoController(IVeiculoService veiculoService)
    {
            this.VeiculoService = veiculoService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        try
        {
            var veiculos = await VeiculoService.getAllVeiculosAsync();
            if (veiculos == null)return NotFound("Nenhum veiculo encontrado");

            return Ok(veiculos);
        }
        catch (Exception ex)
        {
            
            return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar recuperar o veiculo. Erro: {ex.Message}");
        }
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        try
        {
            var veiculo = await VeiculoService.getVeiculosIdByAsync(id);
            if (veiculo == null)return NotFound("Nenhum veiculo encontrado");

            return Ok(veiculo);
        }
        catch (Exception ex)
        {
            
            return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar recuperar o veiculo. Erro: {ex.Message}");
        }

    }

    [HttpGet("{placa}/placa")]
    public async Task<IActionResult> GetByPlaca(string placa)
    {
        try
        {
            var veiculo = await VeiculoService.getAllVeiculosByPlacaAsync(placa);
            if (veiculo == null)return NotFound("Placa do veiculo não encontrada");

            return Ok(veiculo);
        }
        catch (Exception ex)
        {
            
            return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar recuperar o veiculo. Erro: {ex.Message}");
        }

    }
     [HttpPost]
    public async Task<IActionResult> Post(Veiculo model)
    {
        try
        {
            var veiculo = await VeiculoService.AddVeiculo(model);
            if (veiculo == null)return BadRequest("Erro ao adicionar veiculo.");

            return Ok(veiculo);
        }
        catch (Exception ex)
        {
            
            return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar adicionar o veiculo. Erro: {ex.Message}");
        }
    }

     [HttpPut("{id}")]
    public async Task<IActionResult> Put( int id, Veiculo model)
    {
        try
        {
            var veiculo = await VeiculoService.UpdateVeiculo( id, model);
            if (veiculo == null)return BadRequest("Erro ao adicionar veiculo.");

            return Ok(veiculo);
        }
        catch (Exception ex)
        {
            
            return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar atualizar o veiculo. Erro: {ex.Message}");
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete( int id)
    {
        try
        {
            if (await VeiculoService.DeleteVeiculo(id)){
                return Ok("Deletado");
            }
            else{
                return BadRequest("Veiculo não deletado");
            }
        }
        catch (Exception ex)
        {
            
            return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar deletar o veiculo. Erro: {ex.Message}");
        }
    }
}
