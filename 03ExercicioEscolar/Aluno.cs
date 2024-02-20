using System;

class Aluno
{
    // ATRIBUTOS

         public string nome;
         public double nota1, nota2;

    // MÉTODOS
    // Média
        public double media()
        {
            return (nota1+nota2)/2;
        }


    // Situação

        public string situacao(double media)
        {
            return media >= 7 ? "aprovado" : "reprovado";
        }


    // Mensagem
        
        public void mensagem()
        {
            // Oter a Media
                double obterMedia = media();

            // Obter a Situação
                string obterSituacao = situacao(obterMedia);

                Console.WriteLine(nome+" está "+obterSituacao+" com media "+obterMedia);
        }


}