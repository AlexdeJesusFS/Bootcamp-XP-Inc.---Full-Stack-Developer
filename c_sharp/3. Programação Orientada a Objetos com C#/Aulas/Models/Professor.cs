using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aulas.Models
{
    public class Professor : Pessoa
    {
        decimal Salario {get; set;}

        public Professor(string nome, int idade, decimal salario) : base (nome, idade)
        {
            Salario = salario;
        }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, sou o professor {Nome} tenho {Idade} anos e meu salário é {Salario:C}");
        }
    }
}