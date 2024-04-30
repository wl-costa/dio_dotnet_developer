using PessoaClass.Models; // solicita a classe correta através do namespace

Pessoa pessoa1 = new() // nova variável com as props da classe
{
    Nome = "Wendell", // altera a propriedade Nome
    Idade = 18, // altera a propriedade Idade
    Dinheiro = 1286.27M
};

Pessoa pessoa2 = new() // nova variável com as props da classe
{
    Nome = "Thomas", // altera a propriedade Nome
    Idade = 18, // altera a propriedade Idade
    Dinheiro = 816.19M
};

if (pessoa1.Idade >= 18 && pessoa2.Idade >= 18)
{
    Pessoa.ShowDateTime();
    pessoa1.Apresentar();
    pessoa2.Apresentar();
    Pessoa.DinheiroTotalMenosDividaCasal(Pessoa.DinheiroTotalCasal(pessoa1.Dinheiro, pessoa2.Dinheiro));
}
else if (pessoa1.Idade >= 18)
{
    Pessoa.ShowDateTime();
    pessoa1.Apresentar();
    Pessoa.DinheiroTotalMenosDivida(Pessoa.DinheiroTotal(pessoa1.Dinheiro));
}
else if (pessoa2.Idade >= 18)
{
    Pessoa.ShowDateTime();
    pessoa2.Apresentar();
    Pessoa.DinheiroTotalMenosDivida(Pessoa.DinheiroTotal(pessoa2.Dinheiro));
} else
{
    Pessoa.MensagemDeErroIdade();
}

