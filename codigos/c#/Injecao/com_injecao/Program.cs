using Microsoft.Extensions.DependencyInjection;
using service;

class Program
{
	static ServiceProvider RegistrarServices()
    {
        var services = new ServiceCollection();
        services.AddSingleton<IAtendenteService, AtendenteService>(); // #singleton
        services.AddTransient<Controller>(); //transient
        return services.BuildServiceProvider();
    }

	static void Main(String[] args)
	{
		using(ServiceProvider container = RegistrarServices())
        {
            var controller = container.GetRequiredService<Controller>();
            string resultado = controller.Saudacao("Joao");
            Console.WriteLine(resultado);
        }
	}
}