using System.Linq;

namespace NotasAlunos.Models
{
    public class Notas
    {
        private List<double> notas;
        private int maximoDeNotas;

        public Notas(int limite)
        {
            if (limite <= 0)
            {
                throw new ArgumentException("O limite de notas deve ser um número positivo");
            }
            notas = new List<double>();
            maximoDeNotas = limite;
        }

        public void AdicionarNota(double nota)
        {
            if (notas.Count < maximoDeNotas)
            {
                notas.Add(nota);
                Console.WriteLine($"Nota {nota} adicionada com sucesso.");
            }
            else
            {
                Console.WriteLine($"Atenção: Não é possível adicionar mais notas. O limite de {maximoDeNotas} notas foi atingido.");
            }
        }

        public double CalcularMedia()
        {
            if (!notas.Any())
            {
                return 0;
            }
            return notas.Average();
        }

        public override string ToString()
        {
            string notasFormatadas = string.Join(", ", notas);
            return $"Notas: [{notasFormatadas}], Media: {CalcularMedia():F2}";
        }
    }
}