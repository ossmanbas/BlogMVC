using EntityLayer.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql(@"Server=127.0.0.1;Port=5432;Database=myBlog;User Id=postgres;Password=a77ecef7;");
            optionsBuilder.UseSqlServer(@"Server =DESKTOP-R3A8UBN; Database = myBlog;Trusted_Connection=True");
               
        }
        public DbSet<About>  Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Notification> Notifications { get; set; }
       

    }
}
