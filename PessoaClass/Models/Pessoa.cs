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
            Console.WriteLine($"Olá {Nome}. Você possui R${Dinheiro} em conta\n");
        }

        public static void ApresentarCasal(string pessoaNome1, string pessoaNome2)
        {
            Console.WriteLine($"Olá {pessoaNome1} e {pessoaNome2}.\n");
        }

        public static void MensagemDeErroIdade()
        {  
            Console.WriteLine($"Desculpe, você precisa ser maior de 18 anos para rodar esse programa.\n");
        }

        public static void ShowDateTime()
        {
            DateTime dataAtual = DateTime.Now;
            string data = dataAtual.ToString("dd/MM/yyyy");
            string horario = dataAtual.ToString("HH:mm");
            Console.WriteLine($"\nAplicação executada no dia {data} às {horario}\n");
        }

        public static decimal DinheiroTotalCasal(decimal pessoa1, decimal pessoa2)
        {
            decimal dinheiroTotal = pessoa1 + pessoa2;
            Console.WriteLine($"Juntos vocês tem o total de R${dinheiroTotal}\n");
            /*int dinheiroTotalInt = Convert.ToInt32(dinheiroTotal); uma forma de converter decimal para int*/
            /*int dinheiroTotalInt = int.Parse(dinheiroTotal); outra forma de converter decimal para int*/
            return dinheiroTotal;
        }

        public static decimal DinheiroTotal(decimal pessoa)
        {
            decimal dinheiroTotal = pessoa;
            return pessoa;
        }

        public static void DinheiroTotalMenosDividaCasal(decimal dinheiroTotal)
        {
            decimal divida = 500.38M;
            DateTime dataLimite = DateTime.Today.AddDays(28);
            string dataString = dataLimite.ToString("dd/MM/yyyy");
            Console.WriteLine($"Vocês possuem uma dívida de R${divida}\n");
            Console.WriteLine($"Vocês tem até o dia {dataString} para pagar suas dívidas sem cobrança de juros\n");
            Console.WriteLine($"Subtraindo as dívidas, vocês possuem R${dinheiroTotal - divida}\n");
        }

        public static void DinheiroTotalMenosDivida(decimal dinheiro)
        {
            decimal divida = 250.19M;
            DateTime dataLimite = DateTime.Today.AddDays(28);
            string dataString = dataLimite.ToString("dd/MM/yyyy");
            Console.WriteLine($"Você possui uma dívida de R${divida}\n");
            Console.WriteLine($"Você tem até o dia {dataString} para pagar a dívida sem cobrança de juros\n");
            Console.WriteLine($"Subtraindo a dívida, você possui R${dinheiro - divida}\n");
        }
    }
}