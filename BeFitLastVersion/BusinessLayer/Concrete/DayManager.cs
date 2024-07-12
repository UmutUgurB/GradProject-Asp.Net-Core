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
    public class DayManager : IDayService
    {
        private readonly IDayDal _daydal;

        public DayManager(IDayDal dayDal)
        {
            _daydal = dayDal;
        }
        public void Add(Day t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Day t)
        {
            throw new NotImplementedException();
        }

        public Day GetById(int id)
        {
            return _daydal.GetByID(id);
        }

        public List<Day> GetDayById(int id)
        {
            return _daydal.GetListAll().Where(x=> x.WeekID == id).ToList();
        }

        public List<Day> GetList()
        {
            return _daydal.GetListAll();    
        }

        public List<Day> GetListById()
        {
            throw new NotImplementedException();
        }

        public void Update(Day t)
        {
            throw new NotImplementedException();
        }
    }
}
