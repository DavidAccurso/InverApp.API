using Newtonsoft.Json;

namespace InversiApp.API.Models
{
    public class BcraResponseDto
    {
        [JsonProperty("d")]
        public DateTime Date;

        [JsonProperty("v")]
        public double Value;
    }
}
