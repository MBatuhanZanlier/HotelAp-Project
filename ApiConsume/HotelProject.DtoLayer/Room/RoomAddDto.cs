using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Room
{
    public class RoomAddDto
    {

        [Required(ErrorMessage = "Lütfen Oda numarasını Giriniz")]
        public string RoomNumber { get; set; }
        [Required(ErrorMessage = "Lütfen oda görselini Giriniz")]
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Lütfen Fiyat Giriniz")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen Oda başlığı Giriniz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen yatak sayısı Giriniz")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Lütfen banyo Giriniz")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Lütfen  Açıklamayı Giriniz")]
        public string Description { get; set; }
    }
}
