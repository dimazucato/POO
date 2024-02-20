using System;

class Aluno
{
    //ATRIBUTOS//

    private double nota1, nota2;


    //MÉTODOS//
    //MÉDIA//

    private double media()
    {
        return(nota1+nota2)/2;
    }

    //MENSAGEM

    public void mensagem()
    {
        Console.WriteLine("Informe a 1ª nota");
        nota1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Informe a 2ª nota");
        nota2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("A média é "+media());


    }



}