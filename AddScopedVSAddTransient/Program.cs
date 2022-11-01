using AddScopedVSAddTransient;
using Microsoft.Extensions.DependencyInjection;

var collection = new ServiceCollection();
collection.AddScoped<Scoped>();
collection.AddTransient<Transient>();

var builder = collection.BuildServiceProvider();

Parallel.For(1, 10, i =>
{
    Console.WriteLine($"Scoped ID = {builder.GetService<Scoped>().GetHashCode()}");
    Console.WriteLine($"Transient ID = {builder.GetService<Transient>().GetHashCode()}");
});
