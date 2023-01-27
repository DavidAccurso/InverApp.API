using InversiApp.API.Domain;
using InversiApp.API.Middleware;
using InversiApp.API.Repository;
using InversiApp.API.Repository.EF;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using InversiApp;

var MyAllowSpecificOrigins = "policyName";


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins, 
                    policy =>
                    {
                        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                    });
});

var conn = builder.Configuration.GetConnectionString("InvestmentConn");
builder.Services.AddDbContext<InvestmentsContext>(x => x.UseSqlServer(conn));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Auto Mapper Configurations
var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

builder.Services.AddScoped(typeof(IBcraRepository), typeof(BcraRepository));
builder.Services.AddScoped(typeof(IBcraDomain), typeof(BcraDomain));

builder.Services.AddScoped(typeof(IinvestmentRepository), typeof(InvestmentRepository));
builder.Services.AddScoped(typeof(IinvestmentDomain), typeof(InvestmentsDomain));

builder.Services.AddMemoryCache();

var app = builder.Build();

//app.UsePreflightRequestHandler();
app.UseMiddleware<RequestLoggingMiddleware>();

app.UseCors(MyAllowSpecificOrigins);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
