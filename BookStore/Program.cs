using BookStoreBL.Interfaces;
using BookStoreBL.Services;
using BookStoreDL.Interfaces;
using BookStoreDL.Repositories;

namespace BookStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddSingleton<IBookRepository, BookRepository>();

            builder.Services.AddSingleton<IBookService, BookService>();

            builder.Services.AddSingleton<IAuthorRepository, AuthorRepository>();

            builder.Services.AddSingleton<IAuthorService, AuthorService>();

            builder.Services.AddSingleton<ILibraryService, LibraryService>();


            var app = builder.Build();

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
        }
    }
}