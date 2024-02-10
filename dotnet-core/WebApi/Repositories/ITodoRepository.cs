namespace TodoApi.Repositories;

using TodoApi.Models;

public interface ITodoRepository
{
    public Task<Todo> GetTodo(int id);
    public Task<List<Todo>> GetTodos();
}
