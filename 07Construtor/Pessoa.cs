using System;

class Pessoa
{
    //TODO CONSTRUTOR É PUBLIC
    //O construtor é um método de mesmo nome da classe

    public Pessoa()
    {
        Console.WriteLine("Construtor Executado");
    }

    public Pessoa(string nome)
    {
        Console.WriteLine("Olá "+nome);
    }
    
}