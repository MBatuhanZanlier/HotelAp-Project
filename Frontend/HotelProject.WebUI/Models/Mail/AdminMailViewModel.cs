using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Models.Mail
{
    public class AdminMailViewModel
    { 
        public int Id { get; set; } 
        public string senderMail {  get; set; }    
        public string ReciveMail { get; set; } 
        public string Subject { get; set; }  
        public string Body { get; set; }
    }
}
