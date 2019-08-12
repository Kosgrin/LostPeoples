using LostPeople.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostPeople.DataAccess
{
   public  class LostPersonConfiguration : EntityTypeConfiguration<LostPerson>
    {
        public LostPersonConfiguration()
        {
            HasKey(i => i.Id)
                .HasOptional(i => i.LostPersonPhoto);

            //HasOptional(i => i.PhotoId)
            //    .WithOptionalDependent().Map(i => i.ToTable("LostPersonPhotoes")).WillCascadeOnDelete(true);

            //HasOptional(i => i.LostPersonPhoto)
            //    .WithMany().HasForeignKey(x => x.PhotoId);

            //HasIndex(p => p.PhotoId);





        }
    }
}
