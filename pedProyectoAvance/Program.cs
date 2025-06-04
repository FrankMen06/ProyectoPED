using System.Collections.Immutable;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using pedProyectoAvance.Contexto;

namespace pedProyectoAvance;

static class Program
{
    public static IServiceProvider ServiceProvider { get; private set; }
    
    [STAThread]
    static void Main()
    {
        var services = new ServiceCollection();
        string conn = "Data Source=MSI\\SQLDMD;Initial Catalog=ProgramaMedico;User ID=sa;Password=12345;TrustServerCertificate=True;";
        services.AddDbContext<dbContext>(options =>
            options.UseSqlServer(conn));

        services.AddTransient<Form1>();
        ServiceProvider = services.BuildServiceProvider();
        ApplicationConfiguration.Initialize();
        var form = ServiceProvider.GetRequiredService<Form1>();
        Application.Run(form);
    }
}