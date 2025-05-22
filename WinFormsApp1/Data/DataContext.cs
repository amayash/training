using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Models;

namespace WinFormsApp1.Data
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        public virtual DbSet<Book> Books => Set<Book>();
        public virtual DbSet<Publisher> Publishers => Set<Publisher>();

        // Add-Migration InitialCreate для создания миграции, надо открыть вкладку Package Manager Console (Tools -> Nuget Packet Manager -> Package Manager Console)
    }
}
