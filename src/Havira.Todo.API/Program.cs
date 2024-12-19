using FluentValidation;
using Havira.Todo.API.Middleware;
using Havira.Todo.Application;
using Havira.Todo.IoC;

try
{
    var builder = WebApplication.CreateBuilder(args);

    builder.Services.AddSwaggerGen();

    // Add services to the container.
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

    // Add Context to this
    // builder.Services.AddDbContext<DefaultContext>(options =>
    //     options.UseNpgsql(
    //         builder.Configuration.GetConnectionString("DefaultConnection"),
    //         b => b.MigrationsAssembly("Havira.Todo.ORM")
    //     )
    // );

    // add jwt

    builder.RegisterDependencies();

    builder.Services.AddAutoMapper(typeof(Program).Assembly, typeof(Application).Assembly);

    builder.Services.AddMediatR(cfg =>
    {
        cfg.RegisterServicesFromAssemblies(
            typeof(Application).Assembly,
            typeof(Program).Assembly
        );
    });

    var app = builder.Build();

    app.UseMiddleware<ValidationExceptionMiddleware>();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    // app.UseAuthentication();
    // app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    Console.WriteLine("Fatal unexpected error: ", ex);
}
