using System;

class Colaborador : Pessoa

{
    //ATRIBUTOS
    private double salario;


    //MÉTODOS
    private void mensagemColaborador()
    {
        Console.WriteLine("Salário: "+salario);
    }

    //CONSTRUTOR

    public Colaborador(string nome, int idade, double salario)
    {
        this.nome = nome;
        this.idade = idade;
        this.salario = salario;

        mensagemColaborador();
        mensagemPessoa();
        
    }
    
}


