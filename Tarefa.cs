namespace TarefasPessoais.Models
{
    public class Tarefa
    {
        public int NumeroTarefa { get; set; }
        public string Nome { get; set; }
        public Status Status { get; set; }
    }

    public enum Status
    {
        Concluido,
        Pendente
    }
}
