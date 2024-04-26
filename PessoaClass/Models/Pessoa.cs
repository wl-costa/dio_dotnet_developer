using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PessoaClass.Models
{
    public class Pessoa
    {
        public string Nome { get; set; } // propriedade da classe
        public int Idade { get; set; } // propriedade da classe
        public decimal Dinheiro { get; set; }

        public void Apresentar() // um método, a.k.a function (javascript)
        {
            if (Idade >= 18) // checa se a idade é maior ou igual a 18
            {
                Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos. Possuo R${Dinheiro} em conta");
            } else 
            {
                Console.WriteLine($"Desculpe {Nome}, você precisa ser maior de 18 anos para rodar esse programa.");
            }
        }
        
        public static void DinheiroTotal(decimal Pessoa1, decimal Pessoa2)
        {
            decimal dinheiroSomado = Pessoa1 + Pessoa2;
            Console.WriteLine($"Juntos vocês tem o total de {dinheiroSomado}");
        }
    }
}