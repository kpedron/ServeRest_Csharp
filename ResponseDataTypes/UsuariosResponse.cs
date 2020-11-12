using Newtonsoft.Json;
using System.Collections.Generic;

namespace ServeRest.ResponseDataTypes
{
    public class UsuariosResponse
    {
        [JsonProperty("quantidade")]
        public int Quantidade { get; set; }

        [JsonProperty("usuarios")]
        public List<UsuariosInfo> Usuarios { get; set; }
    }

    public class UsuariosInfo
    {
        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("administrador")]
        public string Administrador { get; set; }

        [JsonProperty("_id")]
        public string ID { get; set; }
    }
}
