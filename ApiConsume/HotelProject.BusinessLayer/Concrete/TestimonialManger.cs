using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessEntityLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Concrete
{
    public class TestimonialManger : ITestimonialService
    {
        private readonly ITestimonialDal _testimioalDal;

        public TestimonialManger(ITestimonialDal testimioalDal)
        {
            _testimioalDal = testimioalDal;
        }

        public void TDelete(Testimonial t)
        {
            _testimioalDal.Delete(t);   
        }

        public Testimonial TGetbyId(int id)
        {
           return _testimioalDal.GetbyId(id);
        }

        public List<Testimonial> TGetList()
        {
          return _testimioalDal.GetList();
        }

        public void TInsert(Testimonial t)
        {
           _testimioalDal.Insert(t);
        }

        public void TUpdate(Testimonial t)
        {
           _testimioalDal.Update(t);
        }
    }
}
