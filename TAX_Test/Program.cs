using TAX;

namespace TAX_Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IHost host = Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddHostedService<Worker>();
                    services.AddTaxService();
                })
                .Build();

            host.Run();
        }
    }
}