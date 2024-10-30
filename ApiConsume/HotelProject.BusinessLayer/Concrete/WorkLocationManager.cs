using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessEntityLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Concrete
{
    public class WorkLocationManager : IWorkLocationService
    {
        private readonly IWorkLocationDal _worklocation;

        public WorkLocationManager(IWorkLocationDal worklocation)
        {
            _worklocation = worklocation;
        }

        public void TDelete(WorkLocation t)
        {
            _worklocation.Delete(t);
        }

        public WorkLocation TGetbyId(int id)
        {
           return _worklocation.GetbyId(id);
        }

        public List<WorkLocation> TGetList()
        {
            return _worklocation.GetList();
        }

        public void TInsert(WorkLocation t)
        {
            _worklocation.Insert(t);    
        }

        public void TUpdate(WorkLocation t)
        {
           _worklocation.Update(t);
        }
    }
}
