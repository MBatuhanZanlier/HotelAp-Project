using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    { 
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet] 
        public IActionResult BookingList()
        {
            var values=_bookingService.TGetList(); 
            return Ok(values);
        }
        [HttpPost]   
        public IActionResult AddBooking(Booking booking)
        { 
            _bookingService.TInsert(booking);    
            return Ok("Başarıyla Eklendi");

        }
        [HttpDelete("{id}")] 
        public IActionResult DeleteBooking(int id)  
        {  
           var values=_bookingService.TGetbyId(id); 
            _bookingService.TDelete(values);
            return Ok("Başarıyla Silindi"); 
        
        }
        [HttpPut("UpdateBooking")]
        public IActionResult UpdateBooking(Booking booking)  
        {  
            _bookingService.TUpdate(booking);
            return Ok("Başarıyla Güncellendi");
        
        }

        [HttpGet("{İd}")] 
        public IActionResult GetBooking(int id)  
        {
            var values = _bookingService.TGetbyId(id); 
            return Ok(values);
        
        }
        [HttpPut("ChangeBooking")] 
        public IActionResult ChangeBooking(Booking booking)
        {
            _bookingService.TBookingStatusChangeApproved(booking);
            return Ok("Güncellendi");
        }

        [HttpPut("ChangeBooking2")]
        public IActionResult ChangeBooking2(int id)
        {
            _bookingService.TBookingStatusChangeApproved2(id);
            return Ok("Güncellendi");
        }
    }
}
