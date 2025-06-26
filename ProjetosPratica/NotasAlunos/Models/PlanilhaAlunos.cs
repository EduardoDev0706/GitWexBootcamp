namespace NotasAlunos.Models
{
    public class PlanilhaAlunos
    {
        private Dictionary<string, (Aluno Aluno, Notas Notas)> alunos;

        public PlanilhaAlunos()
        {
            alunos = new Dictionary<string, (Aluno Aluno, Notas Notas)>();
        }

        public void AdicionarAluno(Aluno aluno, Notas notas)
        {
            if (!alunos.ContainsKey(aluno.Matricula))
            {
                alunos.Add(aluno.Matricula, (aluno, notas));
                Console.WriteLine($"Aluno {aluno.Nome} adicionado com sucesso!");
            }
            else
            {
                Console.WriteLine($"Erro: Aluno com matricula {aluno.Matricula} ja esta no sistema.");
            }
        }

        public void ListarAlunos()
        {
            if (!alunos.Any())
            {
                Console.WriteLine("Nenhum aluno cadastrado.");
                return;
            }

            Console.WriteLine("\n--- Lista de Alunos ---");
            foreach (var entry in alunos.Values)
            {
                Console.WriteLine($"{entry.Aluno} - {entry.Notas}");
            }
            Console.WriteLine("-----------------------");
        }

        public void RemoverAluno(string matricula)
        {
            if (alunos.ContainsKey(matricula))
            {
                var alunoRemovido = alunos[matricula].Aluno;
                alunos.Remove(matricula);
                Console.WriteLine($"Aluno {alunoRemovido.Nome} (Matrícula: {matricula}) removido com sucesso!");
            }
            else
            {
                Console.WriteLine($"Erro: Aluno com matrícula {matricula} não encontrado.");
            }
        }

        public (Aluno Aluno, Notas Notas)? ObterAluno(string matricula)
        {
            if (alunos.TryGetValue(matricula, out var dadosAluno))
            {
                return dadosAluno;
            }
            return null;
        }
    }  
}