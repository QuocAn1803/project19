using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Tên xe")]
        public string? CarName { get; set; }

        [DisplayName("Loại xe")]
        public string? CarType { get; set; }

        [DisplayName("Số ghế")]
        public int? TotalSeats { get; set; } // Tổng số ghế

        [DisplayName("Trạng thái")]
        public string? status { get; set; } // Trạng thái (Sẵn sàng/Dã đầy/Đang sử dụng/Đang sửa chữa)

        [DisplayName("Giá/km")]
        public float? pricePerKm { get; set; } // Giá mỗi km

        [DisplayName("Số ghế đã đặt")]
        public int BookedSeats { get; set; } = 0; // Số ghế đã được đặt

        public int Displayorder { get; set; } = 2; // Thứ tự hiển thị: seatremain = 1, available = 2, khác = 3

        // Sau khi đặt chỗ
        [DisplayName("Ngày khởi hành")]
        public DateTime? Startdatetime { get; set; } // Ngày khởi hành

        [DisplayName("Ngày trở về")]
        public DateTime? Returndatetime { get; set; } // Ngày trở về

        [DisplayName("Điểm đón")]
        public string? Origin { get; set; } // Điểm bắt đầu hành trình

        [DisplayName("Điểm đến")]
        public string? Destination { get; set; } // Điểm kết thúc hành trình

        [DisplayName("Khoảng cách")]
        public string? Distance { get; set; } // Khoảng cách, tính từ Google API

        // public string? Duration { get; set; } 
    }
}
