using Newtonsoft.Json;

namespace WebAPI.Models.ComplexData
{
    public class Data
    {
        public int Id { get; set; }
        public string Email { get; set; }
        
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }
        public string Avatar { get; set; }
    }
}
