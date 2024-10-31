
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorPages();

        //Agregando el contexto SupermarketContext a la aplicacion 
        builder.Services.AddDbContext<SumpermarketContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("SupermarketDB"))
        );

        var app = builder.Build();
    }
}

