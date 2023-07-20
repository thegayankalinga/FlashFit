using FlashFitClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashFitClassLibrary.InitialData;

public class CoreServicesApplicationDbContext : DbContext
{
    public CoreServicesApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<CheatmealModel> CheatmealType { get; set; }
    public DbSet<WorkoutModel> WorkoutType { get; set; }

}
