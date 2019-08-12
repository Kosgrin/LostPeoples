using LostPeople.DataAccess.Configuration;
using LostPeople.DataAccess.Entities;
using System.Data.Entity;

namespace LostPeople.DataAccess
{
   public class LostContext :DbContext
    {
        public LostContext()
            : base("name=LostDb")
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<LostContext>());
        }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new LostPersonConfiguration());
            modelBuilder.Configurations.Add(new LostPersonPhotoConfiguration());

            base.OnModelCreating(modelBuilder);

           
        }

        public DbSet<LostPerson> Lost { get; set; }
        public DbSet<LostPersonPhoto> Photos { get; set; }

    }
}
