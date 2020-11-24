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
    public class CtlMedico
    {
        public CtlMedico()
        {

        }

        public List<MdlPaciente> ListaPacientes()
        {
            try
            {
                var requisicaoWeb = WebRequest.CreateHttp($"http://localhost:5000/api/paciente");

                requisicaoWeb.Method = "GET";
                requisicaoWeb.UserAgent = "RequisicaoWebApiAtila";

                using (var resposta = requisicaoWeb.GetResponse())
                {
                    var streamDados = resposta.GetResponseStream();
                    StreamReader reader = new StreamReader(streamDados);
                    object objResponse = reader.ReadToEnd();

                    var pacientes = JsonConvert.DeserializeObject<List<MdlPaciente>>(objResponse.ToString());

                    return pacientes;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> CriarPacienteNoBanco(MdlPaciente paciente)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:5000/api/");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string json = JsonConvert.SerializeObject(paciente);

                string verJson = json.ToString();
                var a = "Teste: " + verJson;

                HttpResponseMessage response = await client.PostAsync("paciente", new StringContent(json, Encoding.UTF8, "application/json"));
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

        public HttpWebResponse DeletarFuncionario(int id)
        {
            try
            {
                var requisicaoWeb = WebRequest.CreateHttp($"http://localhost:5000/api/paciente/{id}");

                requisicaoWeb.Method = "DELETE";
                requisicaoWeb.UserAgent = "RequisicaoWebApiAtila";

                return (HttpWebResponse)requisicaoWeb.GetResponse();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> AtualizarPaciente(MdlPaciente paciente, int id)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:5000/api/");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string json = JsonConvert.SerializeObject(paciente);

                string verJson = json.ToString();
                var a = "Teste: " + verJson;

                HttpResponseMessage response = await client.PutAsync($"paciente/{id}", new StringContent(json, Encoding.UTF8, "application/json"));
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
