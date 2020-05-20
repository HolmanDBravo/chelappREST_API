using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chelappREST_API.Models
{
    public class RolesPermissionsViewModel
    {

        [Newtonsoft.Json.JsonProperty(PropertyName = "idRol")]
        public int IdRol { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "idPermiso")]
        public int IdPermiso { get; set; }

    }
}
