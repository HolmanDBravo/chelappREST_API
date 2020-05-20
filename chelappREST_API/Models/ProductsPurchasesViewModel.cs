using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chelappREST_API.Models
{
    public class ProductsPurchasesViewModel
    {

        [Newtonsoft.Json.JsonProperty(PropertyName = "idpurchases")]
        public int Idpurchases { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "idPublicHouseProducts")]
        public int IdPublicHouseProducts { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "precio")]
        public int Precio { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "cantidad")]
        public int Cantidad { get; set; }

    }
}
