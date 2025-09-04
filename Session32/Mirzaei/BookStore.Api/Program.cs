using System.Reflection;
using BookStore.Application.Commands.User.Create;
using BookStore.Application.Common.Behaviors;
using BookStore.Application.DTOs;
using BookStore.DAL.Contexts;
using BookStore.DAL.Contract;
using BookStore.DAL.Repositories;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(opptions =>
{
    opptions.UseSqlServer(builder.Configuration.GetConnectionString(name: "DefaultConnection"));
});
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssemblies(ApplicationAssemblies.WebAssembly, ApplicationAssemblies.ApplicationAssembly);
    //cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
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

var defaultFiles = new DefaultFilesOptions();
defaultFiles.DefaultFileNames.Clear();
defaultFiles.DefaultFileNames.Add("login.html");
app.UseDefaultFiles(defaultFiles);


app.UseStaticFiles();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

public static class ApplicationAssemblies
{
    public static readonly Assembly WebAssembly = typeof(Program).Assembly;
    public static readonly Assembly ApplicationAssembly = typeof(CreateUserCommand).Assembly;
}