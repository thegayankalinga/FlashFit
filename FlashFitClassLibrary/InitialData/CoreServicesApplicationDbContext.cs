using FlashFitClassLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace FlashFitClassLibrary.InitialData;

public class CoreServicesApplicationDbContext : DbContext
{
    public CoreServicesApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<CheatmealModel> CheatmealType { get; set; }
    public DbSet<WorkoutModel> WorkoutType { get; set; }
    public DbSet<CheatmealRecordModel> CheatmealRecord { get; set; }
    public DbSet<WorkoutRecordModel> WorkoutRecord { get; set; }

}
