using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aulas.Models
{
    public class Professor : Pessoa, ITrabalhador
    {
        decimal Salario {get; set;}

        public void PagarContas()
        {
            Console.WriteLine("Este professor acaba de pagar as suas contas.");
        }

        public Professor(string nome, int idade, decimal salario) : base (nome, idade)
        {
            Salario = salario;
        }

        public override void Hello()
        {
            Console.WriteLine("Eu deveria ganhar mais por isso...");
        }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, sou o professor {Nome} tenho {Idade} anos e meu salário é {Salario:C}");
        }
    }
}