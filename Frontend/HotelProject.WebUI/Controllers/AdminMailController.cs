using HotelProject.WebUI.Models.Mail;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;


namespace HotelProject.WebUI.Controllers
{
    public class AdminMailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AdminMailViewModel mailViewModel)
        { 
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddress = new MailboxAddress("HotelierAdmin", "batuhan.devops@gmail.com"); 
            mimeMessage.From.Add(mailboxAddress); 

            MailboxAddress mailboxaddressto= new MailboxAddress("User",mailViewModel.ReciveMail); 
            mimeMessage.To.Add(mailboxaddressto); 

            var bodyBuilder= new BodyBuilder();
            bodyBuilder.TextBody = mailViewModel.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody(); 

            mimeMessage.Subject = mailViewModel.Subject; 

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 587, false);
            smtpClient.Authenticate("batuhan.devops@gmail.com", "k b u w g e j r g d n b f x i o"); 
            smtpClient.Send(mimeMessage); 
            smtpClient.Disconnect(true);
            return View();
        }
    }
}
