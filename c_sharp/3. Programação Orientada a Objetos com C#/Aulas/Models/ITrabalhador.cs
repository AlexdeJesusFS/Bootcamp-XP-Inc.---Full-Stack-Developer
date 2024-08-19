using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aulas.Models
{
    //Interface: Contrato em que são criados atributos e metodos obrigatorios para serem implementados as classes que implementarem da interface
    public interface ITrabalhador //pratica de nomenclatura com I no começo do nome. 
    {
        // Método com implementação default
        void PagarContas() 
        {
            Console.WriteLine("Acabo de pagar minhas contas e estou com menos dinheiro.");
        } 
    }
}