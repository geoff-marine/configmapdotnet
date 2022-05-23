using Microsoft.Extensions.Configuration;

IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("config/appsettings.json")
    .AddEnvironmentVariables()
    .Build();

Settings settings = config.GetRequiredSection("Settings").Get<Settings>();

string prompt = settings.KeyOne;

var counter = settings.KeyTwo;

var max = args.Length != 0 ? Convert.ToInt32(args[0]) : -1;
while (max == -1 || counter < max)
{
    Console.WriteLine( prompt + " " + ++counter);
    await Task.Delay(TimeSpan.FromMilliseconds(1_000));
}


//await host.RunAsync();