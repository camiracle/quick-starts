namespace TodoApi.Services;

using TodoApi.Models;

public interface ITodoService
{
    public List<Todo> GetTodos();
    public Todo GetTodo(int id);
}
