using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessEntityLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Concrete
{
    public class SubcribeManager : ISubscribeService
    {
        private readonly ISubscribeDal _subscribeDal;

        public SubcribeManager(ISubscribeDal subscribeDal)
        {
            _subscribeDal = subscribeDal;
        }

        public void TDelete(Subscribe t)
        {
          _subscribeDal.Delete(t);
        }

        public Subscribe TGetbyId(int id)
        {
          return _subscribeDal.GetbyId(id); 
        }

        public List<Subscribe> TGetList()
        { 
            return _subscribeDal.GetList(); 
        }

        public void TInsert(Subscribe t)
        {
           _subscribeDal.Insert(t);
        }

        public void TUpdate(Subscribe t)
        { 
            _subscribeDal.Update(t);    
        }
    }
}
