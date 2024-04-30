﻿using PessoaClass.Models; // solicita a classe correta através do namespace

Pessoa pessoa1 = new() // nova variável com as props da classe
{
    Nome = "Wendell", // altera a propriedade Nome
    Idade = 18, // altera a propriedade Idade
    Dinheiro = 1286.27M
};

Pessoa pessoa2 = new() // nova variável com as props da classe
{
    Nome = "Thomas", // altera a propriedade Nome
    Idade = 22, // altera a propriedade Idade
    Dinheiro = 816.19M
};

static void ExecutarPrograma(Pessoa pessoa1, Pessoa pessoa2)
{
    bool idadeValidaPessoa1 = pessoa1.Idade >= 18; // retorna true se for maior de 18 anos
    bool idadeValidaPessoa2 = pessoa2.Idade >= 18;

    if (idadeValidaPessoa1 && idadeValidaPessoa2)
    {
        Pessoa.ShowDateTime();
        Pessoa.ApresentarCasal(pessoa1.Nome, pessoa2.Nome);
        Pessoa.DinheiroTotalMenosDividaCasal(Pessoa.DinheiroTotalCasal(pessoa1.Dinheiro, pessoa2.Dinheiro));
    }
    else if (idadeValidaPessoa1)
    {
        Pessoa.ShowDateTime();
        pessoa1.Apresentar();
        Pessoa.DinheiroTotalMenosDivida(Pessoa.DinheiroTotal(pessoa1.Dinheiro));
    }
    else if (idadeValidaPessoa2)
    {
        Pessoa.ShowDateTime();
        pessoa2.Apresentar();
        Pessoa.DinheiroTotalMenosDivida(Pessoa.DinheiroTotal(pessoa2.Dinheiro));
    }
    else
    {
        Pessoa.MensagemDeErroIdade();
    }
}

ExecutarPrograma(pessoa1, pessoa2);

