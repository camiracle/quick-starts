#Web API
## Quickstart Project
Contents:
- Sample .gitignore and .editorconfig files
- A basic controller, service, data repository, and Sqlite db context.
- Unit test utilizing XUnit and Moq.
- Link: https://dev.azure.com/ostusa/Web%20Dev%20Workspace/_git/quick-starts?path=/web-api

## Getting Started
- Prerequisites
  - .NET SDK
  - Visual Studio, or VS Code with C# extension 
- Download and install [.NET Core](https://dotnet.microsoft.com/en-us/download)

## Create a Web API
```
dotnet new webapi --use-controllers -o TodoApi
cd TodoApi
```

- When Visual Studio Code requests that you add assets to build and debug the project, select Yes. If Visual Studio Code doesn't offer to add build and debug assets, select View > Command Palette and type ".NET" into the search box. From the list of commands, select the .NET: Generate Assets for Build and Debug command.

- Run the API locally:
```
dotnet dev-certs https --trust
dotnet run --launch-profile https
```
- In a browser, navigate to https://localhost:5000/swagger/index.html

# References
- https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-8.0&tabs=visual-studio-code#prerequisites
- https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures


<!-- Swagger/nswag, EF Core, Automapper, dependency injection wire up? -->
