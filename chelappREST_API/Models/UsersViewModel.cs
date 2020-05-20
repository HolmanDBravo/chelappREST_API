using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chelappREST_API.Models
{
    public class UsersViewModel
    {
        
        [Newtonsoft.Json.JsonProperty(PropertyName = "idUsuario")]
        public string IdUsuarios { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "estado")]
        public string Estado { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "fechaUltimaModificacion")]
        public DateTime FechaUltimaModificacion { get; set; }
    }
}
