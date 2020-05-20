using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chelappREST_API.Models
{
    public class PublicHouseViewModel
    {

        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "nombre")]
        public string Nombre { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "descripcion")]
        public string Descripcion { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "estrellas")]
        public int Estrellas { get; set; }


    }
}
