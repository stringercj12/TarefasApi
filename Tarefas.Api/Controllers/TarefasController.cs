using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tarefas.Application.UseCase.Tarefas.Atualizar;
using Tarefas.Application.UseCase.Tarefas.Criar;
using Tarefas.Application.UseCase.Tarefas.Deletar;
using Tarefas.Application.UseCase.Tarefas.ListarPorId;
using Tarefas.Application.UseCase.Tarefas.ListarTodas;
using Tarefas.Communication.Reponse;
using Tarefas.Communication.Request;

namespace Tarefas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {

        [HttpGet]
        [ProducesResponseType(typeof(ResponseListarTodasTarefas), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult ListarTodas()
        {
            var useCase = new ListarTodasTarefasUseCase();
            var response = useCase.Execute();

            if (response.Tarefas.Any())
            {
                return Ok(response);
            }

            return NoContent();
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponseTarefa), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult ListarPorId([FromRoute] int id)
        {

            var useCase = new ListarTarefaPorIdUseCase();
            var response = useCase.Execute(id);

            if (response is null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Atualizar([FromRoute] int id, RequestAtualizarTarefa request)
        {
            var useCase = new AtualizarTarefaUseCase();
            useCase.Execute(id, request);

            return NoContent();
        }
        

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Criar(RequestCriarTarefa request)
        {
            var useCase = new CriarTarefaUseCase();
            useCase.Execute(request);

            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Deletar([FromRoute] int id)
        {
            var useCase = new DeletarTarefaUseCase();
            useCase.Execute(id);

            return NoContent();
        }

    }
}
