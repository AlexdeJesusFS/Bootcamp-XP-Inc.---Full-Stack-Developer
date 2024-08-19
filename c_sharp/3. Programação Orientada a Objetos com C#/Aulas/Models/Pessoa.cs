using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aulas.Models
{
    //classe abstrata: criada somente para ser herdada, reutilizando dessa forma código. Não pode ser instanciada, pois contém meétodos não implemntados.
    public abstract class Pessoa(string nome, int idade)
    {
        public string Nome { get; set; } = nome;
        public int Idade { get; set; } = idade;

        //método abstrato: obrigatório a implementação deste método quando herdado.
        public abstract void Hello();

        //vitual: indica que pode ser sobreescrito
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}