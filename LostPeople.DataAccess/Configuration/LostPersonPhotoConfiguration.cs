using LostPeople.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostPeople.DataAccess.Configuration
{
    public class LostPersonPhotoConfiguration: EntityTypeConfiguration<LostPersonPhoto>
    {
        public LostPersonPhotoConfiguration()
        {


            HasKey(p => p.PhotoId)
               .HasRequired(i => i.LostPerson);
                
                

            //this.HasIndex(p => p.PhotoId);
              


            
        
        }
    }
}
