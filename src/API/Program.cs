using API.Configurations;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddServices(builder.Configuration);

var app = builder.Build();
app.AddApps();
app.Run();