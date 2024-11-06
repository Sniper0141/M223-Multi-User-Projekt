namespace M223_Multi_User_Projekt;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllers();

        var app = builder.Build();

        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.Run();
    }
}