using SQLite;

namespace ProjetoUNG8.SQLite.Models
{
    [Table("Tarefas")]
    public class Tarefas
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Nome { get; set; }
        public int Dificuldade { get; set; }
        public string Imagem { get; set; }
    }
}
