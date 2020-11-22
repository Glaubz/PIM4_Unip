using HospitalModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HospitalControllers
{
    public class CtlFuncionario
    {
        public CtlFuncionario()
        {

        }

        public List<MdlFuncionario> ListaFuncionarios()
        {
            try
            {
                var requisicaoWeb = WebRequest.CreateHttp($"http://localhost:5000/api/funcionario");

                requisicaoWeb.Method = "GET";
                requisicaoWeb.UserAgent = "RequisicaoWebApiAtila";

                using (var resposta = requisicaoWeb.GetResponse())
                {
                    var streamDados = resposta.GetResponseStream();
                    StreamReader reader = new StreamReader(streamDados);
                    object objResponse = reader.ReadToEnd();

                    var funcionarios = JsonConvert.DeserializeObject <List< MdlFuncionario >> (objResponse.ToString()); //<MdlFuncionario>

                    return funcionarios;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public HttpWebResponse DeletarFuncionario(int id)
        {
            try
            {
                var requisicaoWeb = WebRequest.CreateHttp($"http://localhost:5000/api/funcionario/{id}");

                requisicaoWeb.Method = "DELETE";
                requisicaoWeb.UserAgent = "RequisicaoWebApiAtila";

                return (HttpWebResponse)requisicaoWeb.GetResponse();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        //public void CriarFuncionario()
        //{
        //    string dadosPOST = "title=pim4";
        //    dadosPOST = dadosPOST + "&body=teste de envio de post";
        //    dadosPOST = dadosPOST + "&userId=1";

        //    var dados = Encoding.UTF8.GetBytes(dadosPOST);

        //    var requisicaoWeb = WebRequest.CreateHttp($"http://localhost:5000/api/funcionario/");

        //    requisicaoWeb.Method = "POST";
        //    requisicaoWeb.ContentType = "application/x-www-form-urlencoded";
        //    requisicaoWeb.ContentLength = dados.Length;
        //    requisicaoWeb.UserAgent = "RequisicaoWebApiAtila";

        //    using (var stream = requisicaoWeb.GetRequestStream())
        //    {
        //        stream.Write(dados, 0, dados.Length);
        //        stream.Close();
        //    }

        //    using (var resposta = requisicaoWeb.GetResponse())
        //    {
        //        var streamDados = resposta.GetResponseStream();
        //        StreamReader reader = new StreamReader(streamDados);
        //        object objResponse = reader.ReadToEnd();

        //        var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());

        //        Console.WriteLine(post.Id + " " + post.title + " " + post.body);
        //        streamDados.Close();
        //        resposta.Close();
        //    }
        //}

        public async Task<bool> CriarFuncionarioNoBanco(MdlFuncionario funcionario)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:5000/api/");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string json = JsonConvert.SerializeObject(funcionario);

                string verJson = json.ToString();
                var a = "Teste: " + verJson;

                HttpResponseMessage response = await client.PostAsync("funcionario", new StringContent(json, Encoding.UTF8, "application/json"));
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
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> AtualizarFuncionario(MdlFuncionario funcionario, int id)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:5000/api/");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string json = JsonConvert.SerializeObject(funcionario);

                string verJson = json.ToString();
                var a = "Teste: " + verJson;

                HttpResponseMessage response = await client.PutAsync($"funcionario/{id}", new StringContent(json, Encoding.UTF8, "application/json"));
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
