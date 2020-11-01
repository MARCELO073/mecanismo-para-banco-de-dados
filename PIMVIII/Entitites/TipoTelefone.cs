using System;

namespace PIMVIII.Entitites
{
    class TipoTefone
    {
        public int Id { get; set; }
        public string  Tipo { get; set; }

        public TipoTefone(string tipo)
        {
            Tipo = tipo;
        }
        public static TipoTefone preencheTipoTelefone()
        {
          Console.WriteLine("Qual tipo do seu tefone?");
            string tipo = Console.ReadLine();
            return new TipoTefone(tipo);
        }
    }
}
