using System;

namespace API.Models
{
	public class Funcionario
	{
		public int Id { get; set; }

        public string Nome {get; set;}
        public string Email {get; set;}
        public string Cpf {get; set;}
        public string Salario {get; set;}
        public int Idade {get; set;}
        public int Departamento {get; set;}

		public Funcionario()
		{
			
		}

		public Funcionario(string Nome, string Email, string Cpf, string Salario, int Idade, int Departamento)
		{
			this.Nome = Nome;
			this.Email = Email;
			this.Cpf = Cpf;
			this.Salario = Salario;
			this.Idade = Idade;
			this.Departamento = Departamento;
		}

	}
}