using System.Reflection;
using CRM.WebApi;
using CRM.WebApi.Common.Behaviors;
using CRM.WebApi.Users.Commands.CreateUser;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SchemaFilter<UlidSchemaFilter>();
});

builder.Services.AddDbContext<ApplicationDbContext>(opptions =>
{
    opptions.UseSqlServer(builder.Configuration.GetConnectionString(name: "DefaultConnection"));
});

builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
    cfg.AddOpenBehavior(typeof(ValidationBehavior<,>));

});
builder.Services.AddValidatorsFromAssemblyContaining(typeof(CreateUserCommandValidator), includeInternalTypes: true);
builder.Services.AddValidatorsFromAssemblyContaining<CreateUserCommandValidator>(ServiceLifetime.Transient);
builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
