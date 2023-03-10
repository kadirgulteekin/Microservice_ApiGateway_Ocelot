using Contact.API.Services;
using ContactAPI.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.WebHost.ConfigureKestrel(options =>
//{
//    options.ListenAnyIP(7000); // to listen for incoming http connection on port 5001
//    options.ListenAnyIP(7001, configure => configure.UseHttps()); // to listen for incoming https connection on port 7001
//});

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(7001); // to listen for incoming http connection on port 5001
    options.ListenAnyIP(5002, configure => configure.UseHttps()); // to listen for incoming https connection on port 7001
});

builder.Services.AddScoped<IContactService, ContactService>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
