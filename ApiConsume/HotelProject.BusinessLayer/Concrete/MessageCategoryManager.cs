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
    public class MessageCategoryManager : IMessageCategoryService
    {
        private readonly IMessageCategoryDal _messageCategory;

        public MessageCategoryManager(IMessageCategoryDal messageCategory)
        {
            _messageCategory = messageCategory;
        }

        public void TDelete(MessageCategory t)
        {
            _messageCategory.Delete(t);
        }

        public MessageCategory TGetbyId(int id)
        {
            return _messageCategory.GetbyId(id);
        }

        public List<MessageCategory> TGetList()
        {
            return _messageCategory.GetList();
        }

        public void TInsert(MessageCategory t)
        {
            _messageCategory.Insert(t);
        }

        public void TUpdate(MessageCategory t)
        {
            _messageCategory.Update(t);
        }
    }
}
