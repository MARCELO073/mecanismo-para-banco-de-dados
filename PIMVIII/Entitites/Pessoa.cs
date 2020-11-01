

using System;
using System.Data;

namespace PIMVIII.Entitites
{
    class Pessoa
    {
        public int  Id  { get; set; }
        public string Nome { get; set; }
        public long Cpf { get; set; }
        public Endereco endereco { get; set; }
        public Telefone telefone  { get; set; }

        public Pessoa()
        {

        }
        public Pessoa( Endereco endereco, Telefone telefone)
        {
            this.endereco = endereco;
            this.telefone = telefone;
        }
        public Pessoa(string nome, long cpf)
        {
            Nome = nome;
            Cpf = cpf;
            
        }
        public static Pessoa preencherDadosPessoa()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("CPF: ");
            long cpf = long.Parse(Console.ReadLine());
            Endereco.peenchimentoDoEndereco();
            Telefone.preencheTelefone();
            return new Pessoa(nome, cpf);

        } 
    }
}
