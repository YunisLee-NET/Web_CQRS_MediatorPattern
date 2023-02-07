using Microsoft.EntityFrameworkCore;

namespace Parviz.CQRS.WebAPI.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new Student[]
            {
                new(){Id=1,Name="Parviz",Surname="Yunisli",Age=21},
                new(){Id=2,Name="Murad",Surname="Aliyev",Age=21},
                new(){Id=3,Name="Xuraman",Surname="Tagizade",Age=21},
                new(){Id=4,Name="Osman",Surname="Bashirov",Age=22}
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
