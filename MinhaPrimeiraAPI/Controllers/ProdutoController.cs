using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MinhaPrimeiraAPI.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MinhaPrimeiraAPI.Controllers
{
    [Route("fapen/produto")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        // GET: api/<ProdutoController>
        [HttpGet]
        public List<Produto> Get()
        {
            List<Produto> lstProd = new List<Produto>();

            Produto prd1 = new Produto();
            prd1.ID = 1;
            prd1.Descricao = "Computador";
            prd1.Valor = 2000.00;

            lstProd.Add(prd1);


            Produto prd2 = new Produto();
            prd2.ID = 2;
            prd2.Descricao = "SmartTV";
            prd2.Valor = 2500.00;

            lstProd.Add(prd2);


            Produto prd3 = new Produto();
            prd3.ID = 3;
            prd3.Descricao = "celular";
            prd3.Valor = 1500.00;

            lstProd.Add(prd3);


            return lstProd;

            //return new string[] { "value1", "value2" };
        }

        // GET api/<ProdutoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProdutoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProdutoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProdutoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
