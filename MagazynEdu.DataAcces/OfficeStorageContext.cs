using Microsoft.EntityFrameworkCore;
namespace MagazynEdu.DataAcces;

public class OfficeStorageContext : DbContext
{
    public OfficeStorageContext(DbContextOptions<OfficeStorageContext> options) : base(options)
    {
    }
    public DbSet<Entities.Book> Books { get; set; }
    public DbSet<Entities.BookCase> BookCases { get; set; }
    public DbSet<Entities.Author> Authors { get; set; }
}

