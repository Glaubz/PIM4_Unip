using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using HospitalModels;
using System.Net;
using System.IO;

namespace HospitalControllers
{
    public class CtlUsuario
    {   
        public CtlUsuario()
        {
            
        }

        public MdlUsuario GetUsuarioAsync(string login, string senha)
        {
            try
            {
                var requisicaoWeb = WebRequest.CreateHttp($"http://localhost:5000/api/usuario/{login}/{senha}");

                requisicaoWeb.Method = "GET";
                requisicaoWeb.UserAgent = "RequisicaoWebApiAtila";

                using (var resposta = requisicaoWeb.GetResponse())
                {
                    var streamDados = resposta.GetResponseStream();
                    StreamReader reader = new StreamReader(streamDados);
                    object objResponse = reader.ReadToEnd();

                    var usuario = JsonConvert.DeserializeObject<MdlUsuario>(objResponse.ToString());

                    return usuario;
                }
            }
            catch (HttpRequestException ex)
            {
                throw ex;
            }
        }

    }
}
