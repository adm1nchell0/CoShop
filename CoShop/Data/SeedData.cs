using Microsoft.AspNetCore.Identity;
using CoShop.Data;


public class SeedData
{
    public async Task InitializeAsync(ApplicationDbContext context)
    {
        //   var pols = new List<Pol>
        //{
        //       new Pol { Id=1, NamePol="Мужской" },
        //        new Pol { Id=2, NamePol = "Женский"}
        //    };
        //   context.Pols.AddRange(pols);
        await context.SaveChangesAsync();

        var role1 = new IdentityRole("Administrator");

        var role2 = new IdentityRole("Uchenik");

        await context.Roles.AddAsync(role1);

        await context.Roles.AddAsync(role2);

        var user1 = new ApplicationUser
        {
            UserName = "sanya@gmail.com",
            Email = "sanya@gmail.com",
            Surname = "Смирнов",
            Name = "Александр",
            Patronymic = "Павлович",
            PolId = 1,
            DateBirth = DateTime.Parse("31.05.1983"),
            Phone = "234234234234",
            NormalizedEmail = "sanya@gmail.com",
            NormalizedUserName = "sanya@gmail.com",
            LockoutEnabled = true
        };

        var passwordHasher = new PasswordHasher<ApplicationUser>();

        user1.PasswordHash = passwordHasher.HashPassword(user1, "QAZwsx321");

        var res = await context.Users.AddAsync(user1);

        //await context.SaveChangesAsync();

        var res2 = await context.UserRoles.AddAsync(
            new IdentityUserRole<string>
            {
                RoleId = role1.Id,
                UserId = user1.Id
            }
        );

        //await context.SaveChangesAsync();

    }



}
