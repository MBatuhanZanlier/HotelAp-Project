using HotelProject.DataAccessEntityLayer.Abstract;
using HotelProject.DataAccessEntityLayer.Concrete;
using HotelProject.DataAccessEntityLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessEntityLayer.EntityFramework
{
    public class EfWorklocationDal : GenericRepository<WorkLocation>, IWorkLocationDal
    {
        public EfWorklocationDal(Context context) : base(context)
        {
        }
    }
}
