namespace POC.Models
{
    // Estudo de métodos
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ListarQuantidadeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            System.Console.WriteLine($"Alunos do curso de: {Nome}");
            for (int count = 0; count < Alunos.Count; count++)
            {
                string texto = $"N° {count + 1} - {Alunos[count].NomeCompleto}";
                System.Console.WriteLine(texto);
            }
        }

    }
}
