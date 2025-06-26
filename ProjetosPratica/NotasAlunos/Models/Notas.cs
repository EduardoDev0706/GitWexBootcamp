using System.Linq;

namespace NotasAlunos.Models
{
    public class Notas
    {
        private List<double> notas;

        public Notas()
        {
            notas = new List<double>();
        }

        public void AdicionarNota(double nota)
        {
            notas.Add(nota);
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