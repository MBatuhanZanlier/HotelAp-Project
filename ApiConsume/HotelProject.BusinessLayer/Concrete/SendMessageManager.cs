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
    public class SendMessageManager : ISendMessageService
    {
        private readonly ISendMessageDal _service;

        public SendMessageManager(ISendMessageDal service)
        {
            _service = service;
        }

        public void TDelete(SendMessage t)
        { 
            _service.Delete(t);
        }

        public SendMessage TGetbyId(int id)
        {
          return _service.GetbyId(id);
        }

        public List<SendMessage> TGetList()
        { 
           return  _service.GetList();
        }

        public int TGetSendMessageCount()
        {
          return _service.GetSendMessageCount();
        }

        public void TInsert(SendMessage t)
        {
            _service.Update(t);
        }

        public void TUpdate(SendMessage t)
        {
            _service.Update(t);
        }
    }
}
