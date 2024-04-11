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
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos.");
        }
    }
}