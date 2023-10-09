using ClubMembershipApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace ClubMembershipApplication.Data;

public class ClubMembershipDbContext: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data source={AppDomain.CurrentDomain.BaseDirectory}ClubMembership.db");
        base.OnConfiguring(optionsBuilder);
    }
    
    public DbSet<User> Users { get; set; }
}