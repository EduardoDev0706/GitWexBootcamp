using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC.Models
{
    public class Pessoa
    {
        // Construtor vazio, "padrao"
        public Pessoa()
        {
            
        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        private string _nome;
        private int _idade;
        public string Nome

        {
            get => _nome;
            
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;

            }
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        
        public int Idade
        {

            get => _idade;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Uma idade não pode ser menor ou igual a zero");
                }

                _idade = value;

            }

        }

        public void Apresentar()
        {
            System.Console.WriteLine($"Nome: {NomeCompleto}, Idade {Idade}");
        }
    }
}