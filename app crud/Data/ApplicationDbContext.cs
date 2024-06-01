using app_crud.Models;
using Microsoft.EntityFrameworkCore;

namespace app_crud.Data
{
    public class ApplicationDbContext :DbContext 
    {
       public DbSet <Department> Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=db5365.public.databaseasp.net; Database=db5365; User Id=db5365; Password=B-t72Y?pA=w8; Encrypt=False; MultipleActiveResultSets=True;");
        }



    }
}
