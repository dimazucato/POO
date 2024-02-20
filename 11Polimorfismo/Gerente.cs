using System;

class Gerente : Imposto
{

    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine("DescontoVale Alimentação Gerente é de R$" +(salario * 0.15));
    }

    public override void valeTransporte(double salario)
    {
        Console.WriteLine("Desconto padrão do Vale Transporte é de R$" +(salario * 0.06));
    }

}