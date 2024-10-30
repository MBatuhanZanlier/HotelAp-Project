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
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(Context context) : base(context)
        {
        }

        public void BookingStatusChangeApproved(Booking booking)
        {
            var context = new Context();

            var values = context.Bookings.Where(x => x.BookingId == booking.BookingId).FirstOrDefault();
            values.Status = "Onaylandı";
            context.SaveChanges();
        }

        public void BookingStatusChangeApproved2(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = "Onaylandı";
            context.SaveChanges();
        }

        public void BookingStatusChangeApproved3(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = "Onaylandı";  
            context.SaveChanges();
        }

        public int GetBookingCount()
        {
            var context = new Context();
            var values = context.Bookings.Count();
            return values;
        }

        public List<Booking> TGetBookingLastList()
        {
            var context = new Context();
            var values = context.Bookings.OrderByDescending(x => x.BookingId).Take(6).ToList();
            return values;
        }
    }
}
