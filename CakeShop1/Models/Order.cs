using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop1.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }
        [Required(ErrorMessage ="Пожалуйста, укажите Имя")]
        [Display(Name ="First Name")]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Пожалуйста, укажите Фамилию")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Пожалуйста, укажите Отчество")]
        [Display(Name = "Father Name")]
        [StringLength(50)]
        public string FatherName { get; set; }

        [Required(ErrorMessage = "Пожалуйста, укажите адрес доставки")]
        [Display(Name = "Street Adress")]
        [StringLength(100)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Пожалуйста, укажите номер для связи")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        [BindNever]
        public decimal OrderTotal { get; set; }

        [BindNever]
        public DateTime OrderPlaced { get; set; }

    }
}
