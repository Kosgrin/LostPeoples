using LostPeople.DataAccess.Entities;
using LostPeople.DataServices.Models;
using System.Linq;

namespace LostPeople.DataServices.Mapping
{
    public static partial class LostMapping
    {
        public static IQueryable<LostModel> SelectLostModel(this IQueryable<LostPerson> query)
        {
            //var PhotoQuery = query.Select(x => x.LostPersonPhoto).SelectPhotoModel();

            return query.Select(p => new LostModel()
            //return query.Join(PhotoQuery, p => p.PhotoId, c => c.PhotoId, (p, photo) => new LostModel()
            {
                Id = p.Id,
                FIRST_NAME = p.FIRST_NAME,
                LAST_NAME = p.LAST_NAME,
                OVD = p.OVD,
                BIRTH_DATE = p.BIRTH_DATE,
                LOST_DATE = p.LOST_DATE,
                LOST_PLACE = p.LOST_PLACE,
                SEX = p.SEX,
                PhotoId = p.PhotoId,
                          
            
            });
        }

        public static IQueryable<LostPhotoModel> SelectPhotoModel(this IQueryable<LostPersonPhoto> query)
        {


            return query.Select(p => new LostPhotoModel()
            {
                PhotoId = p.PhotoId,
                Photo = p.Photo
                
            });
        }

        
    }
}
