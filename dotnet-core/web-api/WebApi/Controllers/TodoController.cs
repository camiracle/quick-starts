namespace TodoApi.Controllers;

using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;
using TodoApi.Services;

[ApiController]
[Route("[controller]")]
public class TodoController(ILogger<TodoController> logger, ITodoService todoService) : ControllerBase
{
    private readonly ITodoService todoService = todoService;
    private readonly ILogger<TodoController> logger = logger;

    [HttpGet()]
    public IEnumerable<Todo> Get()
    {
        // this.logger.LogInformation("Getting Todos");
        return this.todoService.GetTodos();
    }

    [HttpGet("{id}")]
    public Todo Get(int id)
    {
        // this.logger.LogInformation("Getting Todos");
        return this.todoService.GetTodo(id);
    }
}
