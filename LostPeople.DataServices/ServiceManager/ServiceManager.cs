using LostPeople.DataAccess;
using LostPeople.DataServices.Services;
using System.Data.Entity;

namespace LostPeople.DataServices
{
   public class ServiceManager
    {
        public LostPeopleService Losts { get; }


        public ServiceManager()
        {
            var context = new LostContext();
            Losts = new LostPeopleService(context);
        }
    }
}
