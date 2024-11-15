using System.ComponentModel.DataAnnotations;

namespace CoShop.Models
{
    public class Polzo
    {
        public int Id { get; set; } // Уникальный идентификатор пользователя

        [Required]
        [Display(Name = "Фамилия")]
        [StringLength(255, ErrorMessage = "Минимальное введеное значени не должно быть меньше 2", MinimumLength = 2)]
        public string? Surname { get; set; } // Фамилия пользователя

        [Required]
        [Display(Name = "Имя")]
        [StringLength(255, ErrorMessage = "Минимальное введеное значени не должно быть меньше 2", MinimumLength = 2)]
        public string? Name { get; set; } // Имя пользователя

        [Required]
        [Display(Name = "Отчество")]
        [StringLength(255, ErrorMessage = "Минимальное введеное значени не должно быть меньше 2", MinimumLength = 2)]
        public string? Patronymic { get; set; } // Отчество пользователя

        [Required]
        [Display(Name = "Пол")]
        public int? PolId { get; set; } // Пол пользователя

        [Required]
        [Display(Name = "День рождения")]
        public DateTime? DateBirth { get; set; } // День рождения пользователя

        [Required]
        [Display(Name = "Телефон")]
        [StringLength(255, ErrorMessage = "Минимальное введеное значени не должно быть меньше 2", MinimumLength = 2)]
        public string? Phone { get; set; } // Телефон пользователя

        [Required]
        [Display(Name = "Дата регистрации")]
        public DateTime CreatedAt { get; set; } // Дата и время регистрации пользователя
        public virtual ICollection<Order>? Orders { get; set; } // Заказы, сделанные пользователем
        public virtual ICollection<Review>? Reviews { get; set; } // Отзывы, оставленные пользователем
        public virtual Pol? Pol { get; set; }
    }
}
