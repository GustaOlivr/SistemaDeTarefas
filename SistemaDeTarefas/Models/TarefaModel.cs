using SistemaDeTarefas.Enums;
namespace SistemaDeTarefas.Models
{
    public class TarefaModel
    {
        public int Id { get; set; } //Id da tarefa

        public string? Nome { get; set; } //Nome da tarefa 

        public string? Descricao { get; set; } //Descrição da tarefa

        public StatusTarefa Status { get; set; } // Status da tarefa utilizando Enums
    }
}
