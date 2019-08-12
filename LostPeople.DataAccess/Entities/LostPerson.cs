using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LostPeople.DataAccess.Entities
{
    public class LostPerson
    {
        

        [JsonProperty("ID")]
        
        public string Id { get; set; }

        [JsonProperty("OVD")]
        public string OVD { get; set; }

        [JsonProperty("CATEGORY")]
        public string CATEGORY { get; set; }

        [JsonProperty("FIRST_NAME_R")]
        public string LAST_NAME { get; set; }

        [JsonProperty("LAST_NAME_R")]
        public string FIRST_NAME { get; set; }

        [JsonProperty("MIDDLE_NAME_R")]
        public string MIDDLE_NAME { get; set; }

        [JsonProperty("BIRTH_DATE")]
        [DataType(DataType.Date)]
        public string BIRTH_DATE { get; set; }

        [JsonProperty("SEX")]
        public string SEX { get; set; }

        [JsonProperty("LOST_PLACE")]
        public string LOST_PLACE { get; set; }

        [JsonProperty("LOST_DATE")]
        public string LOST_DATE { get; set; }

        [JsonProperty("CONTACT")]
        public string Contact { get; set; }

        [JsonProperty("PHOTOID")]
        
        public string PhotoId { get; set; }

        public LostPersonPhoto LostPersonPhoto{ get; set; }
       
    
    }
}
