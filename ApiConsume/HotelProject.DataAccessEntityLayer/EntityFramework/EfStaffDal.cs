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
    public class EfStaffDal : GenericRepository<Staff>, IStaffDal
    {
        public EfStaffDal(Context context) : base(context)
        {
        }

        public int GetStaffCount()
        {
            using var context = new Context();
            var values = context.Staffs.Count();
            return values;
        }

        public List<Staff> Last4Staff()
        {
            using var context = new Context();
            var values = context.Staffs.OrderByDescending(x => x.StaffId).Take(4).ToList();
            return values;
        }
    }
}
