﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessEntityLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void TBookingStatusChangeApproved(Booking booking)
        {
            _bookingDal.BookingStatusChangeApproved(booking);
        }

        public void TBookingStatusChangeApproved2(int id)
        {
            _bookingDal.BookingStatusChangeApproved2(id);
        }

        public void TBookingStatusChangeApproved3(int id)
        {
            _bookingDal.BookingStatusChangeApproved3(id);
        }

        public void TDelete(Booking t)
        {
            _bookingDal.Delete(t);
        }

        public int TGetBookingCount()
        {
           return _bookingDal.GetBookingCount();
        }

        public List<Booking> TGetBookingLastList()
        {
            return _bookingDal.TGetBookingLastList();
        }

        public Booking TGetbyId(int id)
        {
            return _bookingDal.GetbyId(id);
        }

        public List<Booking> TGetList()
        {
            return _bookingDal.GetList();
        }

        public void TInsert(Booking t)
        {
           _bookingDal.Insert(t);
        }

        public void TUpdate(Booking t)
        { 
            _bookingDal.Update(t);
        } 
    }
}
