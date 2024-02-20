using System;

class Atendente : Imposto
{

    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto Vale Alimentação Atendente é de R$" +(salario * 0.12));
    }

    public override void valeTransporte(double salario)
    {
        Console.WriteLine("Desconto padrão do Vale Transporte é de R$" +(salario * 0.06));
    }


}