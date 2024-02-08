namespace TodoApi.Services;

using TodoApi.Models;
using TodoApi.Repositories;

public class TodoService(ITodoRepository todoRepository) : ITodoService
{
    private readonly ITodoRepository todoRepository = todoRepository;

    public List<Todo> GetTodos()
    {
        return this.todoRepository.GetTodos();
    }

    public Todo GetTodo(int id)
    {
        return this.todoRepository.GetTodo(id);
    }
}
