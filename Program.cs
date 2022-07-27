using Gitlab2Telegram;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build( );

// Configure the HTTP request pipeline.

//app.UseHttpsRedirection( );

app.MapPost("gitlab/", async (context) =>
    await UpdatesHandler.Handle(context.Request));

app.Run( );
