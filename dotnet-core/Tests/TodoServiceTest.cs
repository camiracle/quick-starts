namespace TodoApi.UnitTests.Services;

using Moq;
using TodoApi.Models;
using TodoApi.Repositories;
using TodoApi.Services;

public class TodoServiceTest
{
    private readonly TodoService todoService;

    public TodoServiceTest()
    {
        var mockTodoData = new List<Todo> { new() { Description = "Pay bills" }, new() { Description = "Exercise" } };
        var mockTodoRepository = new Mock<ITodoRepository>();
        mockTodoRepository
          .Setup(s => s.GetTodos())
          .Returns(mockTodoData);
        mockTodoRepository
          .Setup(s => s.GetTodo(1))
          .Returns(new Todo { TodoId = 1, Description = "Pay bills" });
        mockTodoRepository
          .Setup(s => s.GetTodo(2))
          .Returns(new Todo { TodoId = 1, Description = "Exercise" });
        this.todoService = new TodoService(mockTodoRepository.Object);
    }

    [Fact]
    public void GetsAllTodos()
    {
        var result = this.todoService.GetTodos();
        Assert.Equal("Pay bills", result[0].Description);
        Assert.Equal("Exercise", result[1].Description);
        Assert.Equal(2, result.Count);
    }

    [Theory]
    [InlineData(1, "Pay bills")]
    [InlineData(2, "Exercise")]
    public void GetsRequestedTodo(int id, string expected)
    {
        var result = this.todoService.GetTodo(id);
        Assert.Equal(expected, result.Description);
    }
}
