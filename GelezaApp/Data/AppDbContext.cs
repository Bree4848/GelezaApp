using Microsoft.EntityFrameworkCore;
using GelezaApp.Models; // <--- Add this line!

namespace GelezaApp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<StudyResource> Resources { get; set; }
}