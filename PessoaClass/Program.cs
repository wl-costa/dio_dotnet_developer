﻿using PessoaClass.Models; // solicita a classe correta através do namespace

Pessoa pessoa1 = new() // nova variável com as props da classe
{
    Nome = "Wendell", // altera a propriedade Nome
    Idade = 22, // altera a propriedade Idade
    Dinheiro = 1286.27M
};

Pessoa pessoa2 = new() // nova variável com as props da classe
{
    Nome = "Thomas", // altera a propriedade Nome
    Idade = 20, // altera a propriedade Idade
    Dinheiro = 816.19M
};

Pessoa.ShowDateTime();
pessoa1.Apresentar(); // executa o método / função
pessoa2.Apresentar(); // executa o método / função
Pessoa.DinheiroTotalMenosDivida(Pessoa.DinheiroTotal(pessoa1.Dinheiro, pessoa2.Dinheiro));