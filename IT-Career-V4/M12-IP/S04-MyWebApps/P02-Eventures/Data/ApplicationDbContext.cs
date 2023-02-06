namespace P02_Eventures.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using System;

    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Event> Events { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Order>(option =>
            {
                option
                    .HasOne(x => x.Customer)
                    .WithMany(x => x.Orders)
                    .HasForeignKey(x => x.CustomerId);
            });

            //Create user
            User user = CreateUser("admin@abv.bg");

            builder.Entity<User>().HasData(user);

            //Create roles
            IdentityRole adminRole = CreateRole("Admin");
            IdentityRole customerRole = CreateRole("Customer"); ;

            builder.Entity<IdentityRole>(
                option =>
                {
                    option.HasData(new IdentityRole[]
                    {
                        adminRole,
                        customerRole
                    }
                    );
                });


            //Add user to role
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = adminRole.Id,
                UserId = user.Id
            });

            //Add customers

            for (int i = 0; i < 100; i++)
            {
                User customer = CreateUser($"user{i}@abv.bg");
                builder.Entity<User>().HasData(customer);
                builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
                {
                    RoleId = customerRole.Id,
                    UserId = customer.Id
                });
            }
        }

        private static IdentityRole CreateRole(string roleName)
        {
            return new IdentityRole() { Id = Guid.NewGuid().ToString(), Name = roleName, NormalizedName = roleName };
        }

        private User CreateUser(string email, string password = "123456")
        {
            var hasher = new PasswordHasher<IdentityUser>();
            //Create user
            User user = new User()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = email,
                NormalizedUserName = email,
                Email = email,
                NormalizedEmail = email,
                EmailConfirmed = false,
                PasswordHash = hasher.HashPassword(null, password),
                SecurityStamp = string.Empty
            };

            return user;
        }
    }
}
