var builder = WebApplication.CreateBuilder(args);
// Register MCP server and discover tools from the current assembly
/// Note: WithToolsFromAssembly() automatically discovers and registers tools from the current assembly. 
/// This approach doesn't work well with AOT compilation. 
/// If AOT compilation is required, register tools individually.
/// builder.Services.AddMcpServer()
///    .WithHttpTransport()
///    .WithTools<GreetingTools>();
///    .WithTools<ToolTwo>();
builder.Services.AddMcpServer()
    .WithHttpTransport()
    .WithToolsFromAssembly();

var app = builder.Build();

// Add MCP middleware
app.MapMcp();
app.Run();