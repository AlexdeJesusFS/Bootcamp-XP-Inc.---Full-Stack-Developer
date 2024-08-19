using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aulas.Models
{
    //classe selada(sealed): esta classe não poderá ser herdada, não é capaz de ter filhos
    public sealed class Aluno : Pessoa
    {
        public decimal Nota { get; set; }

        //base: chama o construtor da classe pai para implementar a continuação dele aqui na filha
        public Aluno(string nome, int idade, decimal nota) : base(nome, idade)
        {
            Nota = nota;
        }

        //metodo abstrato herdado da classe pai, obritório implementar ou haverá uma exceção
        //metodo selado: somente metodos virtual herdados podem ser do tipo selado, quando selado o metodo ser torna impossivel de ser sobreescrito por classes que vierem a herda ela
        public sealed override void Hello()
        {
            Console.WriteLine("Eai! Tudo bem você?");
        }

        //overrride(substituir): indica que o metodo herdado será sobreescrito
        public override void Apresentar() 
        {
            Console.WriteLine($"Sou o aluno {Nome}, minha idade é {Idade} anos e minha nota é {Nota}");
        }
    }
}