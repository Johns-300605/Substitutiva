namespace TarefasPessoais.Models
{
    public static class ListaTarefas
    {
        public static List<Tarefa> Tarefas = new List<Tarefa>();

        public static void Dados()
        {
            if (Tarefas.Count > 0) return;

            Tarefas.AddRange(new List<Tarefa>
            {
                new Tarefa { NumeroTarefa = 1, Nome = "Fazer sistema de reservas", Status = Status.Pendente},
                new Tarefa { NumeroTarefa = 2, Nome = "Limpar a casa", Status = Status.Concluido},
                new Tarefa { NumeroTarefa = 3, Nome = "Lavar a louça", Status = Status.Concluido},
                new Tarefa { NumeroTarefa = 4, Nome = "Ir para a consulta", Status = Status.Pendente},
                new Tarefa { NumeroTarefa = 5, Nome = "Ir para a dentista", Status = Status.Pendente},
                new Tarefa { NumeroTarefa = 6, Nome = "Visitar os pais", Status = Status.Concluido},
                new Tarefa { NumeroTarefa = 7, Nome = "Almoçar", Status = Status.Concluido},
                new Tarefa { NumeroTarefa = 8, Nome = "Estudar para a prova", Status = Status.Pendente},
                new Tarefa { NumeroTarefa = 9, Nome = "Cuidar do irmão", Status = Status.Pendente},
                new Tarefa { NumeroTarefa = 10, Nome = "Jogar", Status = Status.Concluido},
                new Tarefa { NumeroTarefa = 11, Nome = "Assistir os filmes da lista", Status = Status.Pendente},
                new Tarefa { NumeroTarefa = 12, Nome = "Jantar", Status = Status.Pendente},
                new Tarefa { NumeroTarefa = 13, Nome = "Ir ao psiquiatra", Status = Status.Concluido},
                new Tarefa { NumeroTarefa = 14, Nome = "Encontro com os amigos", Status = Status.Pendente},
                new Tarefa { NumeroTarefa = 15, Nome = "Sair com a noiva", Status = Status.Concluido},
                new Tarefa { NumeroTarefa = 16, Nome = "Comprar doces pro halloween", Status = Status.Concluido},
                new Tarefa { NumeroTarefa = 17, Nome = "Reservar salão de festa", Status = Status.Concluido},
                new Tarefa { NumeroTarefa = 18, Nome = "Reunião sobre o jogo", Status = Status.Pendente},
                new Tarefa { NumeroTarefa = 19, Nome = "Começar a fazer o jogo", Status = Status.Pendente},
                new Tarefa { NumeroTarefa = 20, Nome = "Terminar o jogo", Status = Status.Pendente}
            });
        }
    }
}
