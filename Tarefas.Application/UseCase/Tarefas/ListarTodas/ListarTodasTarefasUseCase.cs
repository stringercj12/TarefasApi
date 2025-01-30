using Tarefas.Communication.Enums;
using Tarefas.Communication.Reponse;

namespace Tarefas.Application.UseCase.Tarefas.ListarTodas
{
    public class ListarTodasTarefasUseCase
    {
        public ResponseListarTodasTarefas Execute()
        {
            return new ResponseListarTodasTarefas()
            {
                Tarefas = [
                            new ResponseTarefa
                        {
                                Id = 1,
                                Nome = "Task 1",
                                Descricao = "Descrição Da Task 1",
                                DataParaFinalizar = DateTime.Now,
                                Prioridade = TipoDePrioridade.Media,
                                Status = TipoDeStatus.Aguardando
                        },
                        new ResponseTarefa
                        {
                             Id = 2,
                                Nome = "Task 2",
                                Descricao = "Descrição Da Task 2",
                                DataParaFinalizar = DateTime.Now,
                                Prioridade = TipoDePrioridade.Alta,
                                Status = TipoDeStatus.EmAndamento
                        }
                ]
            };

        }
    }
}
