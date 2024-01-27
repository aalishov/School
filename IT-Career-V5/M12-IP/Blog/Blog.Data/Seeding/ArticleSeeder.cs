using Blog.Data.Models;
using Blog.Data.Seeding.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Data.Seeding
{
    public class ArticleSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Articles.Any())
            {
                return;
            }
            var userManager = serviceProvider.GetRequiredService<UserManager<User>>();

            List<Article> articles = new List<Article>();

            for (int i = 0; i < 50; i++)
            {
                articles.Add(new Article
                {
                    Title = $"Title {i}",
                    Description = $"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nunc sed velit dignissim sodales ut. Enim nec dui nunc mattis enim. Habitasse platea dictumst vestibulum rhoncus est pellentesque elit ullamcorper dignissim. ",
                    Author = dbContext.Users.FirstOrDefault()
                });
            }
            await dbContext.Articles.AddRangeAsync(articles);
            await dbContext.SaveChangesAsync();
        }
    }
}
