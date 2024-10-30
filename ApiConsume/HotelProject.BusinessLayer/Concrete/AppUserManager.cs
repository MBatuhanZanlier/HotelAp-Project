using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessEntityLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDal _appuserDal;

        public AppUserManager(IAppUserDal appuserDal)
        {
            _appuserDal = appuserDal;
        }

        public int TAppUserCount()
        {
           return _appuserDal.AppUserCount();
        }

        public void TDelete(AppUser t)
        { 
            _appuserDal.Delete(t);
        }

        public AppUser TGetbyId(int id)
        { 
            return _appuserDal.GetbyId(id);
        }

        public List<AppUser> TGetList()
        { 
            return _appuserDal.GetList();
        }

        public void TInsert(AppUser t)
        { 
            _appuserDal.Insert(t);  
        }

        public void TUpdate(AppUser t)
        { 
            _appuserDal.Update(t);
        }

        public List<AppUser> TUserListWithWorkLocation()
        { 
            return _appuserDal.UserListWithWorkLocation();
        }
    }
}
