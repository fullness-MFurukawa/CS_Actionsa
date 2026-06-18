using CS_Actions_WebApp.Models;

using Microsoft.EntityFrameworkCore;

namespace CS_Actions_WebApp.Infrastructures;
/// <summary>
/// データベースコンテキストクラス
/// </summary>
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }
}