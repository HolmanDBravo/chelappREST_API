using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chelappREST_API.Models
{
    public class PurchasesViewModel
    {

        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "idUsuario")]
        public string idUsuario { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "fechaCompra")]
        public DateTime FechaCompra { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "preciototal")]
        public int PrecioTotal { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "fechaRecibido")]
        public DateTime FechaRecibido { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "tipoPago")]
        public DateTime TipoPago { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "estrellas")]
        public int Estrellas { get; set; }

    }
}
