namespace TodoApi.Repositories;

using TodoApi.Models;

public interface ITodoRepository
{
    public Todo GetTodo(int id);
    public List<Todo> GetTodos();
}
