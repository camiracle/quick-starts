namespace TodoApi.Seed;

using TodoApi.Models;

public class TodoSeed
{
    public static void Seed()
    {
        var db = new TodoContext();

        db.Add(new Todo { Description = "Change oil" });
        db.Add(new Todo { Description = "Walk the dog" });

        db.SaveChanges();
    }
}
