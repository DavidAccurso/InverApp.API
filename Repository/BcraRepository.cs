using InversiApp.API.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace InversiApp.API.Repository
{
    public class BcraRepository : IBcraRepository
    {
        private HttpClient _http;
        private string token = "eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJleHAiOjE2OTkzNjE0NzMsInR5cGUiOiJleHRlcm5hbCIsInVzZXIiOiJkYXZpZG1hY2N1cnNvQGdtYWlsLmNvbSJ9.lNMV2LeN1Nq9Tj9R3Z7g15utDMTqJkadClLu5tKJLYsrC2gdV4b8muvcw2Vw2UW_8M9o4kDZfPvfE15gdJZToA";
        private string bcraUrl = @"https://api.estadisticasbcra.com";

        public BcraRepository()
        {
            this._http = new HttpClient();
        }
        public async Task<BcraResponseDto> GetLastPrice()
        {
            _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            _http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await _http.GetAsync(bcraUrl + "/usd").Result.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<BcraResponseDto[]>(response);

            return json.Reverse().FirstOrDefault();
        }
    }
}
