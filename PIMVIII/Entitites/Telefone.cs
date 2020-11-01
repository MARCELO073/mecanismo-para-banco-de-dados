using System;

namespace PIMVIII.Entitites
{
    class Telefone
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public int DDD { get; set; }
        public TipoTefone tipo { get; set; }
        public Telefone(TipoTefone tipo)
        {
            this.tipo = tipo;
        }
        public Telefone(int numero, int dDD)
        {
            Numero = numero;
            DDD = dDD;
        }
        public static Telefone preencheTelefone()
        {
            Console.WriteLine();
            Console.WriteLine("Entre com seus contatos! ");
            Console.Write("Numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("DDD: ");
            int ddd = int.Parse(Console.ReadLine());
            TipoTefone.preencheTipoTelefone();
            return new Telefone(numero, ddd);
        }
    }
}
