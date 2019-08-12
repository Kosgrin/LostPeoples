using System.Data.Entity;
using System.Collections.Generic;
using LostPeople.DataAccess.Entities;
using LostPeople.DataServices.Models;
using System.Linq;
using LostPeople.DataServices.Mapping;
using System.Data.SqlClient;
using System.Data;

namespace LostPeople.DataServices.Services
{
   public  class LostPeopleService
    {
        private readonly DbContext _context;
        private readonly DbSet<LostPerson> _LostSet;
        private readonly DbSet<LostPersonPhoto> _LostPhotoSet;

        public LostPeopleService(DbContext context)
        {
            _context = context;
            _LostSet = context.Set<LostPerson>();
            _LostPhotoSet = context.Set<LostPersonPhoto>();
        }

        public List<LostModel> GetLostPeople(int count)
        {
            return _LostSet.OrderBy(p => p.LAST_NAME)
                .Take(count)
                .SelectLostModel()
                .ToList();
        }

        public List<LostModel> Search()
        {
            return _LostSet.OrderBy(p => p.LAST_NAME)
                .SelectLostModel()
                .ToList();
        }

        public List<LostModel> Find(string Id)
        {
            return _LostSet.OrderBy(p => p.Id)
                .Where(p => p.Id.ToString() == Id)
                .SelectLostModel()
                .ToList();
           
        }

        

        

    }
}
