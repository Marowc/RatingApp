using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RatingAPP.Data;

namespace RatingAPP.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<RatingAPP.Data.Book> Book { get; set; } = default!;
    public DbSet<RatingAPP.Data.Comment> Comment { get; set; } = default!;
}

