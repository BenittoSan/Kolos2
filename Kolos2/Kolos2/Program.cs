using System.Text.Json.Serialization;
using Kolos2.Context;
using Kolos2.Interfaces;
using Kolos2.Repository;
using Kolos2.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers().AddJsonOptions(x =>
    x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddDbContext<Kolos2Context>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});


//Repository
builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IDiscountReposiotory, DiscountRepository>();
builder.Services.AddScoped<IClientSubscriptionRepository, ClientSubscriptionRepository>();
builder.Services.AddScoped<ISubRepository, SubRepository>();


//services
builder.Services.AddScoped<IClientSubscriptionService, ClientSubscriptionService>();


var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();



app.Run();

