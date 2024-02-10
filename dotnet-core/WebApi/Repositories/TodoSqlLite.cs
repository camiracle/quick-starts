namespace TodoApi.Repositories;

using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

public class TodoSqlLite : ITodoRepository
{
    private readonly TodoContext _context;

    public TodoSqlLite(TodoContext context)
    {
        _context = context;
    }

    public async Task<List<Todo>> GetTodos()
    {
        return await _context.Todo.ToListAsync();
    }

    public async Task<Todo> GetTodo(int id)
    {
        return await _context.Todo.FirstOrDefaultAsync(t => t.TodoId == id);
    }
}
