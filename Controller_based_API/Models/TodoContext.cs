using Controller_based_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Controller_based_API.Models;
// DbContext is an external class that represents a session with the database and can be used to query and save instances of the entities.
// DbContext is a base class in EF that provides the core database  functionality
public class TodoContext : DbContext
{
    // <TodoContext> is a generic type parameter that refers to the DbContext subclass, which in this instance is the TodoContext class. 
    // DbContextOptions<TodoContext>, options is of type TodoContext, which is configured using DbContextOptions
    // <TodoContext> is what the type is, and DbContextOptions is how to create it.
    // Options is a DbContextOptions object that is intended specifically for configuring a TodoContext, which is a subclass of DbContext
    // If TodoContext is a pizza, then DbContextOptions is the recipe. 
    public TodoContext(DbContextOptions<TodoContext> options)
    // base passes the options to the base DbContext constructor to properly initialise it
        : base(options)
    {
    }
    // DbSet tells EF core that TodoItem is an entity in the db and to map to the db table.
    public DbSet<TodoItem> TodoItems { get; set; } = null!;
    
}