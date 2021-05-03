using BlogApp.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogApp.Data.Concrete.EntityFrameworkCore
{
    public static class SeedData
    {
        public static void EnsurePopulated(BlogContext context)
        {
            //BlogContext context = app.ApplicationServices.GetRequiredService<BlogContext>();

            context.Database.EnsureCreated();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new Category { Name = "Category 1" },
                    new Category { Name = "Category 2" },
                    new Category { Name = "Category 3" }
                    );
                context.SaveChanges();
            }

            if (!context.Blogs.Any())
            {
                context.Blogs.AddRange(
                    new Blog() { Title = "Blog Title 1", Description = "Blog Description", Body = "Blog Body 1", Image = "1.jpg", Date = DateTime.Now.AddDays(-5), IsApproved = true, CategoryId = 1 },
                    new Blog() { Title = "Blog Title 2", Description = "Blog Description", Body = "Blog Body 2", Image = "2.jpg", Date = DateTime.Now.AddDays(-7), IsApproved = true, CategoryId = 1 },
                    new Blog() { Title = "Blog Title 3", Description = "Blog Description", Body = "Blog Body 3", Image = "3.jpg", Date = DateTime.Now.AddDays(-8), IsApproved = false, CategoryId = 2 },
                    new Blog() { Title = "Blog Title 4", Description = "Blog Description", Body = "Blog Body 4", Image = "4.jpg", Date = DateTime.Now.AddDays(-9), IsApproved = true, CategoryId = 3 }
                    );
                context.SaveChanges();
            }
        }
    }
}
