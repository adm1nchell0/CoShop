using CoShop.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace CoShop.Models
{
    public class Review
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "ID Курса")]
        public int CourseId { get; set; }

        [Required]
        [Display(Name = "ID Пользователя")]
        public string ApplicationUserId { get; set; }

        [Required]
        [Display(Name = "Оценка")]
        [Range(1, 5, ErrorMessage = "Рейтинг должен быть от 1 до 5")]
        public int Rating { get; set; }

        [Required]
        [Display(Name = "Комментарий")]
        [StringLength(255, ErrorMessage = "Минимальное введеное значени не должно быть меньше 2", MinimumLength = 2)]
        public string? Comment { get; set; }

        [Required]
        [Display(Name = "Дата создания")]
        public DateTime CreatedAt { get; set; }

        public virtual Course Course { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
