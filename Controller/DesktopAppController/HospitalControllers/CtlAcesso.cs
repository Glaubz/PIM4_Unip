using HospitalModels;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace HospitalControllers
{
    public class CtlAcesso
    {
        private readonly HttpClient _httpClient;

        public CtlAcesso()
        {
            _httpClient = new HttpClient();
        }

        public async Task<MdlAcesso> GetUsuarioAsync(string login, string senha)
        {
            try
            {
                HttpResponseMessage _response = await _httpClient.GetAsync("https://run.mocky.io/v3/524da213-ce4a-4ca0-81cb-57c3e451c0fb");

                string _body = await _response.Content.ReadAsStringAsync();

                MdlAcesso usuario = JsonConvert.DeserializeObject<MdlAcesso>(_body);

                return usuario;
            }
            catch (HttpRequestException ex)
            {
                throw ex;
            }
        }
    }
}
