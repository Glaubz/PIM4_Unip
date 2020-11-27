using HospitalModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HospitalControllers
{
    public class CtlConsulta
    {
        public CtlConsulta()
        {

        }

        public List<MdlConsulta> ListaConsultas()
        {
            try
            {
                var requisicaoWeb = WebRequest.CreateHttp($"http://localhost:5000/api/consulta");

                requisicaoWeb.Method = "GET";
                requisicaoWeb.UserAgent = "RequisicaoWebApiAtila";

                using (var resposta = requisicaoWeb.GetResponse())
                {
                    var streamDados = resposta.GetResponseStream();
                    StreamReader reader = new StreamReader(streamDados);
                    object objResponse = reader.ReadToEnd();

                    var consultas = JsonConvert.DeserializeObject<List<MdlConsulta>>(objResponse.ToString());

                    return consultas;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public HttpWebResponse DeletarConsulta(int id)
        {
            try
            {
                var requisicaoWeb = WebRequest.CreateHttp($"http://localhost:5000/api/consulta/{id}");

                requisicaoWeb.Method = "DELETE";
                requisicaoWeb.UserAgent = "RequisicaoWebApiAtila";

                return (HttpWebResponse)requisicaoWeb.GetResponse();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> CriarConsultaNoBanco(MdlConsulta consulta)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:5000/api/");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string json = JsonConvert.SerializeObject(consulta);

                string verJson = json.ToString();
                var a = "Teste: " + verJson;

                HttpResponseMessage response = await client.PostAsync("consulta", new StringContent(json, Encoding.UTF8, "application/json"));
                response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> AtualizarConsulta(MdlConsulta consulta, int id)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:5000/api/");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string json = JsonConvert.SerializeObject(consulta);

                string verJson = json.ToString();
                var a = "Teste: " + verJson;

                HttpResponseMessage response = await client.PutAsync($"consulta/{id}", new StringContent(json, Encoding.UTF8, "application/json"));
                response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
