using System;

class Pessoa
{
    //MÉTODO 01
    public void apresentar()
    {
        Console.WriteLine("Olá!!!");
    }

    //MÉTODO 02

    public void apresentar(string nome)
    {
        Console.WriteLine("Olá "+nome);
    }


    //MÉTODO 03
     public void apresentar(string nome, int idade)
    {
        Console.WriteLine("Olá "+nome+" você tem "+idade+" anos");
    }


}