using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessEntityLayer.Abstract
{
   public interface IBookingDal:IGenericDal<Booking>
    { 
        public void BookingStatusChangeApproved(Booking booking);
        public void BookingStatusChangeApproved2(int id);
        public int GetBookingCount();
        List<Booking> TGetBookingLastList();
        void BookingStatusChangeApproved3(int id); 
    }
}
