using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace chelappREST_API.Models
{
    
    public class Personal_informationViewModel
    {

        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "secondName")]
        public string SecondName { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "surname")]
        public string Surname { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "secondSurname")]
        public string SecondSurname { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "identificationNumber")]
        public string IdentificationNumber { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "mail")]
        public string Mail { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "tipoIdentificacion")]
        public string TipoIdentificacion { get; set; }

    }
}
