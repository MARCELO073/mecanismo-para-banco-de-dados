using System;

namespace PIMVIII.Entitites
{
    class Endereco
    {
        public int id { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public int Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Endereco( string logradouro, int numero, int cep, string bairro, string cidade, string estado)
        {
            id = 0;
            Logradouro = logradouro;
            Numero = numero;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
    
        }
        public static Endereco peenchimentoDoEndereco()
        {
            Console.WriteLine();
            Console.WriteLine("Digite seu enderço!" );
            Console.Write("logradouro: ");
           string logradouro = Console.ReadLine(); 
            Console.Write("Numero: ");
            int numero = int.Parse(Console.ReadLine());           
            Console.Write("Cep :");
            int cep = int.Parse(Console.ReadLine());           
            Console.Write("Bairro: ");
            string bairro = Console.ReadLine();            
            Console.Write("Cidade: ");
            string Cidade = Console.ReadLine();      
            Console.Write("Estado: ");
            string estado = Console.ReadLine();

            return new Endereco (logradouro, numero, cep, bairro, Cidade, estado);
        }



    }
}
