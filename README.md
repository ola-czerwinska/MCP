# MCP

## Testing the Server

To verify your MCP server works:

1. Run the server application with [Dev Tunnel](https://learn.microsoft.com/en-us/aspnet/core/test/dev-tunnels?view=aspnetcore-9.0).
2. Navigate to `https://DevtunnelDomain/sse` in your browser.
3. You should see a response indicating the MCP server is running.

For only debugging / playground purpose, you have to set "public" access, as there is known issue with auth headers size that ends with 431 http error.
See: https://github.com/microsoft/dev-tunnels/issues/425

## Initial Commit Reference

This solution's initial commit was done based on the following article:  
[Building a Server-Sent Event (SSE) MCP Server with .NET Core C#](https://medium.com/@hany.habib1988/building-a-server-sent-event-sse-mcp-server-with-net-core-c-48ac55000336) by @Hany.Fakhry@dnv.com
