using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostPeople.DataServices.Models
{
   public class LostModel
    {
       
        public string Id { get; set; }

       
        public string OVD { get; set; }

       
        public string CATEGORY { get; set; }

       
        public string LAST_NAME { get; set; }

       
        public string FIRST_NAME { get; set; }

       
        public string MIDDLE_NAME { get; set; }

       
        public string BIRTH_DATE { get; set; }

       
        public string SEX { get; set; }

        
        public string LOST_PLACE { get; set; }

        
        public string LOST_DATE { get; set; }


        public string PhotoId { get; set; }


        public string Contact { get; set; }


        public ICollection<LostPhotoModel> Photo { get; set; }


        
    }
}
