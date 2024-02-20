using System;

class Pessoa{

    //ATRIBUTOS

    protected string nome;
    protected int idade;

    //MÉTODO
    protected void mensagemPessoa()
    {
        Console.WriteLine("Nome: " +nome);
        Console.WriteLine("Idade: " +idade);
    }

}