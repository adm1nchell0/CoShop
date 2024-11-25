using Microsoft.AspNetCore.Identity;
using CoShop.Models;
using System.ComponentModel.DataAnnotations;

namespace CoShop.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        //public int Id { get; set; }
        public string? Surname { get; set; }

        public string? Name { get; set; }

        public string? Patronymic { get; set; }

        public DateTime? DateBirth { get; set; }

        public DateTime CreatedAt { get; set; } // Дата и время регистрации пользователя

        public string? Phone { get; set; }

        public int? PolId { get; set; }

        public virtual ICollection<Order>? Orders { get; set; } // Заказы, сделанные пользователем
        public virtual ICollection<Review>? Reviews { get; set; } // Отзывы, оставленные пользователем
        public Pol? Pol { get; set; }
    }
}
