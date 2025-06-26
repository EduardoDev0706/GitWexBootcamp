using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotasAlunos.Models
{
    public class Aluno
    {

        public Aluno() { }
        public string Nome { get; set; }
        public string Matricula { get; set; }

        public Aluno(string nome)
        {
            Nome = nome;
        }

        public Aluno(string nome, string matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Matricula: {Matricula}";
        }
    }
}