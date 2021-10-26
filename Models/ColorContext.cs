using Microsoft.EntityFrameworkCore;

namespace DockerComposeAPI.Models
{
    class ColorContext : DbContext
    {
        public ColorContext(DbContextOptions<ColorContext> options) : base(options)
        {
            
        }

        public DbSet<Color> ColorItems { get; set; }
    }
}