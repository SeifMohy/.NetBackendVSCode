using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace shipping_backend.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }
        public DbSet<Shipment> Shipments { get; set; } = null!;
        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}