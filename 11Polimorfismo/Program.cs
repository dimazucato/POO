﻿using System;

class Program
{

    static void Main(string[] args)
    {

        //INSTÂNCIA DO ESTAGIÁRIO
        Imposto objetoE = new Estagiario();
        objetoE.valeAlimentacao(1000);
        objetoE.valeTransporte(1000);
        Console.WriteLine("------------");

        //INSTÂNCIA DO ATENDENTE
        Imposto objetoA = new Atendente();
        objetoA.valeAlimentacao(2000);
        objetoA.valeTransporte(2000);
        Console.WriteLine("------------");

        
        //INSTÂNCIA DO GERENTE
        Imposto objetoG = new Gerente();
        objetoG.valeAlimentacao(5000);
        objetoG.valeTransporte(5000);
        Console.WriteLine("------------");
       
        




        
    }

}

