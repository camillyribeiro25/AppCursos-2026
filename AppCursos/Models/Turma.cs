namespace AppCursos.Models
{
    public class Turma
    {
        public int Id { get; set; } // Chave Primária (Primary Key)
        public string Nome { get; set; }
        public int CursoId { get; set; } // Chave Estrangeira (Foreign Key)

        public Curso? Curso { get; set; } // Propriedade de navegação
    }
}
