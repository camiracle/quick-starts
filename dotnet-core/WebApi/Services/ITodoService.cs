namespace TodoApi.Services;

using TodoApi.Models;

public interface ITodoService
{
    public Task<List<Todo>> GetTodos();
    public Task<Todo> GetTodo(int id);
}
