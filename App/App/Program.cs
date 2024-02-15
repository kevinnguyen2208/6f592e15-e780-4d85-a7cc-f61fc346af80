using App.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ILongestIncreasingSubsequenceService, LongestIncreasingSubsequenceService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseCors(options =>
options.WithOrigins("http://localhost:4800")
.AllowAnyMethod()
.AllowAnyHeader());

app.UseAuthorization();

app.MapControllers();

app.Run();
