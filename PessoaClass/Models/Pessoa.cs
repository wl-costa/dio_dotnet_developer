using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PessoaClass.Models
{
    public class Pessoa
    {
        public required string Nome { get; set; } // propriedade da classe
        public int Idade { get; set; } // propriedade da classe
        public decimal Dinheiro { get; set; }

        public void Apresentar() // um método, a.k.a function (javascript)
        {
            if (Idade >= 18) // checa se a idade é maior ou igual a 18
            {
                Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos. Possuo R${Dinheiro} em conta\n");
            }
            else
            {
                Console.WriteLine($"Desculpe {Nome}, você precisa ser maior de 18 anos para rodar esse programa.\n");
            }
        }

        public static void ShowDateTime()
        {
            DateTime dataAtual = DateTime.Now;
            string data = dataAtual.ToString("dd/MM/yyyy");
            string horario = dataAtual.ToString("HH:mm");
            Console.WriteLine($"\nAplicação executada no dia {data} às {horario}\n");
        }

        public static decimal DinheiroTotal(decimal Pessoa1, decimal Pessoa2)
        {
            decimal dinheiroTotal = Pessoa1 + Pessoa2;
            Console.WriteLine($"Juntos vocês tem o total de R${dinheiroTotal}\n");
            return dinheiroTotal;
        }

        public static void DinheiroTotalMenosDivida(decimal dinheiro)
        {
            decimal divida = 500.38M;
            DateTime dataLimite = DateTime.Today.AddDays(28);
            string dataString = dataLimite.ToString("dd/MM/yyyy");
            Console.WriteLine($"Vocês possuem uma dívida de R${divida}\n");
            Console.WriteLine($"Vocês tem até o dia {dataString} para pagar suas dívidas sem cobrança de juros\n");
            Console.WriteLine($"Subtraindo as dívidas, vocês possuem R${dinheiro - divida}\n");
        }
    }
}