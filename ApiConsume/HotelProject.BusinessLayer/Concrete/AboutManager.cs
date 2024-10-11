using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessEntityLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void TDelete(About t)
        {
            _aboutDal.Delete(t);
        }

        public About TGetbyId(int id)
        { 
           return _aboutDal.GetbyId(id);
        }

        public List<About> TGetList()
        {
           return _aboutDal.GetList();
        }

        public void TInsert(About t)
        {
           _aboutDal.Insert(t);
        }

        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
