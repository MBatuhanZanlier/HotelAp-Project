﻿using HotelProject.DataAccessEntityLayer.Abstract;
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
    public class EfTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal
    {
        public EfTestimonialDal(Context context) : base(context)
        {
        }
    }
}
