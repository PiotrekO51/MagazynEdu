using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MagazynEdu.DataAcces;

public class OfficeStorageContextFactory:IDesignTimeDbContextFactory<OfficeStorageContext>
{
    public OfficeStorageContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<OfficeStorageContext>();
        optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress02;Initial Catalog=MagazynEduStorage;Integrated Security=True;Trust Server Certificate=True");
        return new OfficeStorageContext(optionsBuilder.Options);
    }
}

