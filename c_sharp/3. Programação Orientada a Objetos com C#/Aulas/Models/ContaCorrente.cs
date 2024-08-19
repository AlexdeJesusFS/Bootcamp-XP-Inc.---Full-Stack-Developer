using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

//Abstração: extrair as informações necessárias e importantes ao contexto para a representação da classe no sistema.
//Encapsulamento: proteger os campos da classe para alteração somente da própria classe ou seus herdeiros para previnir alterações indevidas.
//Herança: capacidade da classe herda ou ser herdada o seu código (campos e métodos), dessa forma evitando duplicidade de código. cada classe pode herdar somente uma classe.
//Polimorfismo: classe com métodos que podem ser sobreescritos por suas classes filhas, dessa forma é garantido que cada classe terá o método deseja, porém cada uma com sua propria implementação para atender o seu contexto e necessidade.
//Polimorfismo Overload → Classe com metodos do mesmo nome porém sua implemtentação é diferente, indenpende de herança.
//Polimorfismo Override → Classe com metodos que são sobreescritos por sua classe filha, depende da herança.

namespace Aulas.Models
{
    public class ContaCorrente(int id, decimal saldoInicial) 
    {
        public int Id { get; set; } = id;
        private decimal Saldo = saldoInicial;

        public void Sacar(decimal valor) 
        {
            if (valor >= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine("Saque bem sucedido!");
            }
            else
            {
                Console.WriteLine("Valor do saque maior que o saldo disponível!");
            }
        }
    }
}