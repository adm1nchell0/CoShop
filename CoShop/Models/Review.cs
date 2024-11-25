using System.ComponentModel.DataAnnotations;
using CoShop.Data;

namespace CoShop.Models
{
    public class Review
    {
        public int Id { get; set; } // Уникальный идентификатор отзыва

        [Required]
        [Display(Name = "ID Курса")]
        public int CourseId { get; set; } // Идентификатор курса, к которому относится отзыв

        [Required]
        [Display(Name = "ID Пользователя")]
        public string ApplicationUserId { get; set; } // Идентификатор пользователя, оставившего отзыв

        [Required]
        [Display(Name = "Возраст")]
        public int Rating { get; set; } // Оценка курса (например, от 1 до 5)

        [Required]
        [Display(Name = "Комментарий")]
        [StringLength(255, ErrorMessage = "Минимальное введеное значени не должно быть меньше 2", MinimumLength = 2)]
        public string? Comment { get; set; } // Комментарий пользователя к курсу

        [Required]
        [Display(Name = "Дата создания")]
        public DateTime CreatedAt { get; set; } // Дата и время создания отзыва

        public virtual Course? Course { get; set; } // Курс, к которому относится отзыв
        public virtual ApplicationUser? ApplicationUser { get; set; } // Пользователь, оставивший отзыв
    }
}
