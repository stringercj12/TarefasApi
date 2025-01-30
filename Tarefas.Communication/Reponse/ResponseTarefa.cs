using Tarefas.Communication.Enums;

namespace Tarefas.Communication.Reponse
{
    public class ResponseTarefa
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public TipoDePrioridade Prioridade { get; set; }
        public DateTime DataParaFinalizar { get; set; }
        public TipoDeStatus Status { get; set; }
    }
}
