using System;
using Microsoft.AspNetCore.Mvc;
using TarefasBackendCrud.Models;
using TarefasBackendCrud.Repositorio;
namespace TarefasBackendCrud.Controlles
{
    [ApiController]
    [Route("Tarefa")]
    public class TarefasControlles : ControllerBase
    {
        [HttpGet]
        public IActionResult Read([FromServices] ItarefaRepository repository)
        {
            var tarefas = repository.Read();
            return Ok(tarefas);
        }
        [HttpPost]
        public IActionResult creat([FromBody]Tarefa models, [FromServices]ItarefaRepository Repository)
        {
            if(!ModelState.IsValid)
                return BadRequest();
            Repository.Creat(models);

            return Ok();
        }
    }
}