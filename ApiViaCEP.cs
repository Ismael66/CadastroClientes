using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CadastroClientesWF
{
    public class ApiViaCEP
    {
        public static async Task<ViaCep> ConsultarCep(string cep)
        {
            string resultado = string.Empty;
            try
            {
                HttpClient cliente = new HttpClient();
                resultado = await cliente.GetStringAsync("https://viacep.com.br/ws/" + cep + "/json/");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Cep invalido.\n{ex.Message}");
            }
            return JsonConvert.DeserializeObject<ViaCep>(resultado);
        }
    }
}
