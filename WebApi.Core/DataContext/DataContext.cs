using Microsoft.EntityFrameworkCore;
using WebApi.Core.Models;

namespace WebApi.Core.DataContext
{
    public class MhsContext : DbContext
    {
        public MhsContext(DbContextOptions<MhsContext> options)
            : base(options)
        {
        }
        public DbSet<MahasiswaModel> Mahasiswas { get; set; }

    }
}
