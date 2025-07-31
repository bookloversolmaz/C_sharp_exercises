using Controller_based_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Controller_based_API.Models;
// DbContext is an external class that represents a session with the database and can be used to query and save instances of the entities.
public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
    {
    }

    public DbSet<TodoItem> TodoItems { get; set; } = null!;
    // public DbSet<TodoItemDTO> TodoItemsDTO { get; set; } = null!;
    
}