using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraAPI.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MinhaPrimeiraAPI.Controllers
{
    [Route("fapen/cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        // GET: api/<ClienteController>
        [HttpGet]
        public List<Cliente> Get()
        {

            Cliente objCli = new Cliente();
            return objCli.RetornarClientes();

            // return new string[] { "value1", "value2" };
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {

            Cliente objCli = new Cliente();
            List<Cliente> listCliente = objCli.RetornarClientes();

            Cliente cli = listCliente.Where(p => p.Id == id).FirstOrDefault();

            if (cli.Id == 3)
            {
                return "Cliente premiado";
            }
            else
            {
                return "Tente outra vez";
            }

           
        }

        // POST api/<ClienteController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
