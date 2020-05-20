using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chelappREST_API.Models
{
    public class PermissionsViewModel
    {

        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "vista")]
        public string Vista { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "descripcion")]
        public string Descripcion { get; set; }

    }
}
