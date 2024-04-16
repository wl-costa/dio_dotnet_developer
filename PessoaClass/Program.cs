using PessoaClass.Models; // solicita a classe correta através do namespace

Pessoa pessoa1 = new() // nova variável
{
    Nome = "Wendell", // altera a propriedade Nome
    Idade = 18 // altera a propriedade Idade
};

pessoa1.Apresentar(); // executa o método / função