using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PersonalBlog.Models;

namespace PersonalBlog.Persistence
{
    public class PersonalBlogContext : DbContext
    {
        public PersonalBlogContext (DbContextOptions<PersonalBlogContext> options)
            : base(options)
        {
        }

        public DbSet<PersonalBlog.Models.CategoryModel> CategoryModel { get; set; }

        public DbSet<PersonalBlog.Models.PostModel> PostModel { get; set; }
    }
}
