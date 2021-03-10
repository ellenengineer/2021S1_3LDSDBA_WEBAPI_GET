using System;
using System.IO;
using System.Net;
using System.Text;

namespace TesteAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            TesteGet();
        }

        static void TesteGet()
        {
            //Criando uma requisição
            var request = (HttpWebRequest)WebRequest.Create("https://localhost:44346/fapen/cliente");
           // var request = (HttpWebRequest)WebRequest.Create("http://localhost:8080/fapen/cliente");

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            Console.WriteLine(responseString);
            Console.ReadLine();

        }

     
    }
}
