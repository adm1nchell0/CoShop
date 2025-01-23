using System.ComponentModel.DataAnnotations;

namespace CoShop.Models
{
    public class Cat
    {
        public int Id { get; set; } // Уникальный идентификатор категории

        [Required]
        [Display(Name = "Категория")]
        [StringLength(255, ErrorMessage = "Минимальное введеное значени не должно быть меньше 2", MinimumLength = 2)]
        public string? Name { get; set; } // Название категории
        public virtual ICollection<Course>? Courses { get; set; } // Курсы, относящиеся к данной категории
    }
}
