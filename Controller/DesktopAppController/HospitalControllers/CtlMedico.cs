﻿using HospitalModels;
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

        public List<MdlMedico> ListaMedicos()
        {
            try
            {
                var requisicaoWeb = WebRequest.CreateHttp($"http://localhost:5000/api/medico");

                requisicaoWeb.Method = "GET";
                requisicaoWeb.UserAgent = "RequisicaoWebApiAtila";

                using (var resposta = requisicaoWeb.GetResponse())
                {
                    var streamDados = resposta.GetResponseStream();
                    StreamReader reader = new StreamReader(streamDados);
                    object objResponse = reader.ReadToEnd();

                    var medicos = JsonConvert.DeserializeObject<List<MdlMedico>>(objResponse.ToString());

                    return medicos;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> CriarMedicoNoBanco(MdlMedico medico)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:5000/api/");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string json = JsonConvert.SerializeObject(medico);

                string verJson = json.ToString();
                var a = "Teste: " + verJson;

                HttpResponseMessage response = await client.PostAsync("medico", new StringContent(json, Encoding.UTF8, "application/json"));
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

        public HttpWebResponse DeletarMedico(int id)
        {
            try
            {
                var requisicaoWeb = WebRequest.CreateHttp($"http://localhost:5000/api/medico/{id}");

                requisicaoWeb.Method = "DELETE";
                requisicaoWeb.UserAgent = "RequisicaoWebApiAtila";

                return (HttpWebResponse)requisicaoWeb.GetResponse();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> AtualizarMedico(MdlMedico medico, int id)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:5000/api/");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string json = JsonConvert.SerializeObject(medico);

                string verJson = json.ToString();
                var a = "Teste: " + verJson;

                HttpResponseMessage response = await client.PutAsync($"medico/{id}", new StringContent(json, Encoding.UTF8, "application/json"));
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
