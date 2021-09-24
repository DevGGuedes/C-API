using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using SqlKata.Compilers;
using SqlKata.Extensions;
using MySqlConnector;
using System.Data;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ILogger<ClienteController> _logger;

        public ClienteController(ILogger<ClienteController> logger)
        {
            _logger = logger;
        }

        //Mostra Request no swagger
        [HttpGet]
        public IEnumerable<Cliente> GetAll()
        {
            var rng = new Random();
            
            //var db = new QueryFactory(connection, compiler);
            //var query = new Query("Users").Where("Id", 1).Where("Status", "Active");


            return Enumerable.Range(1, 5).Select(index => new Cliente
            {
                Id = 1,
                Nome = "Gabriel"
            }).ToArray();
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<Return> GetForId([FromForm] int Id)
        {
            var rng = new Random();
            return new Return($"Recebido {Id}");
            /*return Enumerable.Range(1, 5).Select(index => new Cliente
            {
                Id = 1,
                Nome = "Gabriel"
            }).ToArray();*/
        }

        [HttpPost]
        public async Task<Return> PostCliente(Cliente cliente) 
        //public async string PostCliente(Cliente cliente)
        {
            //List<Cliente> cli = new List<Cliente>();
            //cli.Add(new Cliente(cliente.Id, cliente.Nome));

            return new Return($"Enviado {cliente.Id} e {cliente.Nome}");
        }
    }
}