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
            Console.WriteLine(DateTime.Now);
            if (Idade >= 18) // checa se a idade é maior ou igual a 18
            {
                Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos. Possuo R${Dinheiro} em conta\n");
            }
            else
            {
                Console.WriteLine($"Desculpe {Nome}, você precisa ser maior de 18 anos para rodar esse programa.\n");
            }
        }

        public static decimal DinheiroTotal(decimal Pessoa1, decimal Pessoa2)
        {
            decimal DinheiroTotal = Pessoa1 + Pessoa2;
            Console.WriteLine($"Juntos vocês tem o total de R${DinheiroTotal}\n");
            return DinheiroTotal;
        }

        public static void DinheiroTotalMenosDivida(decimal Dinheiro)
        {
            decimal divida = 500.38M;
            Console.WriteLine($"Vocês possuem uma dívida de R${divida}\n");
            Console.WriteLine($"Subtraindo as dívidas, vocês possuem R${Dinheiro - divida}\n");
        }
    }
}