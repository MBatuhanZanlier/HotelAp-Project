using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessEntityLayer.Abstract
{
   public interface IAppUserDal:IGenericDal<AppUser>
    {
        List<AppUser> UserListWithWorkLocation();
        public int AppUserCount();
    }
}
