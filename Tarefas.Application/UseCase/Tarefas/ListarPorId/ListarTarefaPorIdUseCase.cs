using Tarefas.Communication.Enums;
using Tarefas.Communication.Reponse;

namespace Tarefas.Application.UseCase.Tarefas.ListarPorId
{
    public class ListarTarefaPorIdUseCase
    {
        public ResponseTarefa Execute(int id)
        {
            return new ResponseTarefa()
            {
                Id = 1,
                Nome = "Task 1",
                Descricao = "Descrição Da Task 1",
                DataParaFinalizar = DateTime.Now,
                Prioridade = TipoDePrioridade.Media,
                Status = TipoDeStatus.Aguardando
            };
        }
    }
}
