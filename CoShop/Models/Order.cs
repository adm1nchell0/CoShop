using System.ComponentModel.DataAnnotations;

namespace CoShop.Models
{
    public class Order
    {
        public int Id { get; set; } // Уникальный идентификатор заказа

        [Required]
        [Display(Name = "ID Пользователя")]
        public int PolzoId { get; set; } // Идентификатор пользователя, сделавшего заказ

        [Required]
        [Display(Name = "ID Курса")]
        public int CourseId { get; set; } // Идентификатор курса, который был куплен

        [Required]
        [Display(Name = "Дата оформления")]
        public DateTime OrderDate { get; set; } // Дата и время оформления заказа

        [Required]
        [Display(Name = "Сумма заказа")]
        public decimal TotalAmount { get; set; } // Общая сумма заказа
        public virtual Polzo? Polzo { get; set; } // Пользователь, сделавший заказ
        public virtual Course? Course { get; set; } // Курс, который был куплен
    }
}
