using System; 

    class Pessoa
    {
        //ATRIBUTO
        private string nome = "Tatiana";

        //CONSTRUTOR
        public Pessoa(string nome)
        {
            Console.WriteLine(nome);
            Console.WriteLine(this.nome);
        }
    }

