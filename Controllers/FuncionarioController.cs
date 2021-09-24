using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using SqlKata.Compilers;
using SqlKata;
using SqlKata.Execution;
using System.Data.SqlClient;
using Npgsql;
using MySqlConnector;
using System.Data;
using API.Models;

namespace API.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class FuncionarioController : ControllerBase
    {
        private readonly ILogger<FuncionarioController> _logger;

        public FuncionarioController(ILogger<FuncionarioController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<Return> PostFuncionario(Funcionario func)
        //public async string PostCliente(Cliente cliente)
        {
            Console.WriteLine($"Dados Recebidos: {func.Idade}, {func.Nome}");
            return new Return($"Enviado");
        }

        [HttpGet]
        public async Task<Funcionario> GetFuncionario()
        {
            
            /*var connection = new MySqlConnection(
                "Host=localhost;Port=3306;User=root;Password=;Database=UNIP_LPBD;"
            );*/
            Conexao con = new Conexao();
            var compiler = new MySqlCompiler();

            var db = new QueryFactory(con.Conectar(), compiler);

            var query = db.Query("funcionario as func")
                .SelectRaw("func.cd_funcionario")
                .SelectRaw("func.nm_funcionario");

            var response = query.Get<Funcionario>()
                .Select(funci => {
                    funci.Id = (int)(funci?.Id);
                    funci.Nome = funci?.Nome?.Trim();
                    return funci;
                }).ToArray();

            /*var compiler = new MySqlCompiler();
            var conn = new MySqlConnection("Host=localhost;Port=3306;User=root;Password=;Database=unip_lgbd;");
            conn.Open();
            
            var command = new MySqlCommand("SELECT * FROM funcionario;", conn);*/

            /*var connection = new MySqlConnection(
				"Host=localhost;Port=3306;User=user;Password=secret;Database=Users;SslMode=None"
			);*/
            
            //var db = new QueryFactory(connection, new MySqlCompiler());

            /*connection.Open();

            var command = new MySqlCommand("SELECT * FROM funcionario;", connection);
            var reader = command.ExecuteReader();*/

            List<Funcionario> f = new List<Funcionario>();

            return new Funcionario
            {
                Id = 1
            };
        }

    }
}