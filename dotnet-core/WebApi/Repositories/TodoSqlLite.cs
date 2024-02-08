namespace TodoApi.Repositories;

using TodoApi.Models;

public class TodoSqlLite : ITodoRepository, IDisposable
{
    private readonly TodoContext db = new();
    public List<Todo> GetTodos()
    {
        return this.db.Todo.ToList();
    }

    public Todo GetTodo(int id)
    {
        return this.db.Todo.First(t => t.TodoId == id);
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}
