using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LostPeople.DataAccess.Entities
{
    public class LostPersonPhoto
    {
       
        [JsonProperty("Id")]
        
        public string PhotoId { get; set; }
        
        [JsonProperty("PhotoBase64Encode")]
        public string Photo { get; set; }

        
        public LostPerson LostPerson { get; set; }
        
    }
}
