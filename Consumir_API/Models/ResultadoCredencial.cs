using Newtonsoft.Json;

namespace Consumir_API.Models
{
    public class ResultadoCredencial
    {
        [JsonProperty("message")]
        public string token { get; set; }   
    }
}
