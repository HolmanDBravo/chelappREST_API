using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chelappREST_API.Models
{
    public class PromotionsViewModel
    {

        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "fechaIni")]
        public DateTime FechaIni { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "fechaFin")]
        public DateTime FechaFin { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "idArticulo")]
        public string IdArticulo { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "rutaArchivo")]
        public string RutaArchivo { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "precio")]
        public int Precio { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "descripcion")]
        public string Descripcion { get; set; }
        

    }
}
