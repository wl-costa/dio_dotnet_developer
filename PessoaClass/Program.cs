﻿using PessoaClass.Models; // solicita a classe correta através do namespace

Pessoa pessoa1 = new() // nova variável
{
    Nome = "Wendell", // altera a propriedade Nome
    Idade = 22, // altera a propriedade Idade
    Dinheiro = 1286.27M
};

Pessoa pessoa2 = new() // nova variável
{
    Nome = "Thomas", // altera a propriedade Nome
    Idade = 18, // altera a propriedade Idade
    Dinheiro = 816.19M
};

pessoa1.Apresentar(); // executa o método / função
pessoa2.Apresentar(); // executa o método / função