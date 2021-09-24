using System;

namespace API
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nome {get; set;}

        public Cliente()
        {

        }

        public Cliente(int Id, string Nome)
        {
            this.Nome = Nome;
            this.Id = Id;
        }

    }

}