namespace TodoApi.Models;

using Microsoft.EntityFrameworkCore;
using System;

public class TodoContext : DbContext
{
    public DbSet<Todo> Todo { get; set; }

    public string DbPath { get; }

    public TodoContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        this.DbPath = Path.Join(path, "todo.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite($"Data Source={this.DbPath}");
}

public class Todo
{
    public int TodoId { get; set; }
    public string? Description { get; set; }
    public bool IsComplete { get; set; }
}
