
using WebProject.Api.Dependency_Injection;
using WebProject.Api.Repository;
using WebProject.Api.Service;

namespace WebProject.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Service : Register
            var builder = WebApplication.CreateBuilder(args);

            var classB = new ClassB(new ClassA());


            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //builder.Services.AddTransient<IRepository, EFRepository>();
            builder.Services.AddTransient<IRepository, EFRepository>();
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddSingleton<ISingletonPattern, SingletonPattern>();



            // Middleware
            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
