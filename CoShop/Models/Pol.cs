using System.ComponentModel.DataAnnotations;

namespace CoShop.Models
{
    public class Pol
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Пол")]
        [StringLength(255, ErrorMessage = "Минимальное введеное значени не должно быть меньше 2", MinimumLength = 2)]
        public string? NamePol { get; set; }

        public virtual ICollection<Polzo>? Polzos { get; set; } // Курсы, относящиеся к данной категории
    }
}
