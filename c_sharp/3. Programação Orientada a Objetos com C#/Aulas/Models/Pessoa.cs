using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aulas.Models
{
    public class Pessoa(string nome, int idade)
    {
        public string Nome { get; set; } = nome;
        public int Idade { get; set; } = idade;

        //vitual: indica que pode ser sobreescrito
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}