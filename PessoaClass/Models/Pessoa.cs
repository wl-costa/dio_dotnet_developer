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

        public void Apresentar() // um método, a.k.a function (javascript)
        {
            if (Idade >= 18) // checa se a idade é maior ou igual a 18
            {
                Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos.");
            } else 
            {
                Console.WriteLine($"Você precisa ser maior de 18 anos para rodar esse programa.");
            }
        }
    }
}