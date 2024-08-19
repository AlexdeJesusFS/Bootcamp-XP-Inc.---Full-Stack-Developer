using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aulas.Models
{
    public class Aluno : Pessoa
    {
        public decimal Nota { get; set; }

        //base: chama o construtor da classe pai para implementar a continuação dele aqui na filha
        public Aluno(string nome, int idade, decimal nota) : base(nome, idade)
        {
            Nota = nota;
        }

        //overrride(substituir): indica que o metodo herdado será sobreescrito
        public override void Apresentar() 
        {
            Console.WriteLine($"Sou o aluno {Nome}, minha idade é {Idade} anos e minha nota é {Nota}");
        }
    }
}