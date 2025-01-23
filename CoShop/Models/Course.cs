using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.ComponentModel.DataAnnotations;

namespace CoShop.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Название")]
        [StringLength(255, ErrorMessage = "Ввод не может быть меньше 2 символов", MinimumLength = 2)]
        public string? Title { get; set; }

        [Required]
        [Display(Name = "Описание")]
        [StringLength(255, ErrorMessage = "Ввод не может быть меньше 2 символов", MinimumLength = 2)]
        public string? Description { get; set; }

        [Required]
        [Display(Name = "Цена")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Дата создания")]
        public DateTime CreatedAt { get; set; }

        [Required]
        [Display(Name = "ID Категории")]
        public int CatId { get; set; }

        [Required]
        [Display(Name = " Путь к изображению")]
        public string? ImageUrl { get; set; } // Путь к изображению

        public virtual ICollection<Lesson>? Lessons { get; set; }
        public virtual ICollection<Review>? Reviews { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }
        public virtual Cat? Cat { get; set; }
    }
}
