namespace AppCursos.Models
{
    public class AlunoTurma
    {
        public int Id { get; set; } // Chave Primária (Primary Key)
        public int AlunoId { get; set; } // Chave Estrangeira (Foreign Key)
        public int TurmaId { get; set; } // Chave Estrangeira (Foreign Key)
        public Aluno Aluno { get; set; } // Propriedade de navegação
        public Turma? Turma { get; set; } // Propriedade de navegação
    }
}
