namespace M223_Multi_User_Projekt;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllers();
        builder.Services.AddMvc();
        builder.Services.AddEndpointsApiExplorer();

        var app = builder.Build();

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthorization();
        
        app.MapControllers();

        app.Run();
    }
}