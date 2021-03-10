using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaPrimeiraAPI.Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string CPF { get; set; }


        public List<Cliente> RetornarClientes()
        {
            List<Cliente> listClient = new List<Cliente>();

            Cliente cli1 = new Cliente();
            cli1.Id = 1;
            cli1.Nome = "Ellen";
            cli1.CPF = "11111111111";


            Cliente cli2 = new Cliente();
            cli2.Id = 2;
            cli2.Nome = "Sindel";
            cli2.CPF = "22222222222";


            Cliente cli3 = new Cliente();
            cli3.Id = 3;
            cli3.Nome = "Fulano";
            cli3.CPF = "333333333333";


            Cliente cli4 = new Cliente();
            cli4.Id = 4;
            cli4.Nome = "Aluno";
            cli4.CPF = "5555555555555";

            listClient.Add(cli1);
            listClient.Add(cli2);
            listClient.Add(cli3);
            listClient.Add(cli4);

            return listClient;
        }
    }
}
