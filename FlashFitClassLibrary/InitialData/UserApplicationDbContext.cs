using FlashFitUserManagementService;
using Microsoft.EntityFrameworkCore;

namespace FlashFitClassLibrary.InitialData
{
    public class UserApplicationDbContext : DbContext
    {
        public UserApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<UserModel> Users { get; set; }
    }
}
