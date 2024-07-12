using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PlaceManager : IPlaceService
    {
        private readonly IPlaceDal _placedal;

        public PlaceManager(IPlaceDal placeDal)
        {
            _placedal = placeDal;
        }

        public void Add(Place t)
        {
            _placedal.Insert(t);    
        }

        public void AddComment(int placeId)
        {
            throw new NotImplementedException();
        }

        public void Delete(Place t)
        {
            throw new NotImplementedException();
        }

        public Place GetById(int id)
        {
            return _placedal.GetByID(id);
        }

        public List<Place> GetDetailById(int id)
        {
            return _placedal.GetListAll().Where(x=> x.PlaceID == id).ToList();
        }

        public List<Place> GetList()
        {
            return _placedal.GetListAll();  
        }

        public List<Place> GetListById()
        {
            throw new NotImplementedException();
        }

        public void Update(Place t)
        {
            throw new NotImplementedException();
        }
    }
}
