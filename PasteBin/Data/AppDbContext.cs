using Microsoft.EntityFrameworkCore;
using PasteBin.Models;

namespace PasteBin.Data
{
    /// <summary>
    /// Application database context
    /// </summary>
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        /// <summary>
        /// Set of pastes
        /// </summary>
        public DbSet<Paste> Pastes { get; set; }
    }
}