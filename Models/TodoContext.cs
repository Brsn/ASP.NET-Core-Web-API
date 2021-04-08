using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    // the colon here is for inheriting DbContext class
    public class TodoContext : DbContext
    {
        //constructior passing in DbContext options
        public TodoContext(DbContextOptions<TodoContext> options)

             // : base is used to refer to the base class when chaining constructors
             : base(options)
        {
        }
            public DbSet<TodoItem> TodoItems { get; set; }
    }
    }        
