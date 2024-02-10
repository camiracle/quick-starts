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
    public async Task<IEnumerable<Todo>> Get()
    {
        // this.logger.LogInformation("Getting Todos");
        return await this.todoService.GetTodos();
    }

    [HttpGet("{id}")]
    public async Task<Todo> Get(int id)
    {
        // this.logger.LogInformation("Getting Todos");
        return await this.todoService.GetTodo(id);
    }
}
