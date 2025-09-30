using signalR.Business;
using signalR.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Business / Service kayıtları
builder.Services.AddTransient<MyBusiness>();

// SignalR
builder.Services.AddSignalR();

// Controllers
builder.Services.AddControllers();

// CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.SetIsOriginAllowed(origin => true)
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials();
    });
});

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Sıralama çok önemli
app.UseRouting();
app.UseCors();

// Swagger sadece geliştirmede çalışsın
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Controller ve SignalR endpointleri
app.MapControllers();
app.MapHub<MyHub>("/myhub");
app.MapHub<MessageHub>("/messagehub");

app.Run();
