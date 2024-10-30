using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IBookingService : IGenericService<Booking>
    {
        public void TBookingStatusChangeApproved(Booking booking);
        public void TBookingStatusChangeApproved2(int id);
        public int TGetBookingCount();
        List<Booking> TGetBookingLastList();
        void TBookingStatusChangeApproved3(int id);
    }
}
