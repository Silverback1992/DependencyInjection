using Microsoft.Extensions.DependencyInjection;
using ServiceCollectionAndServiceProvider;
using ServiceCollectionAndServiceProvider.Interfaces;

var collection = new ServiceCollection();
collection.AddScoped<IDataAccess, DataAccess>();
collection.AddScoped<IBusiness, Business>();

var provider = collection.BuildServiceProvider();

//IDataAccess DAL = provider.GetService<IDataAccess>();
//we can comment this out bc it is automatically created as business needs it
//.NET can automatically create it
IBusiness business = provider.GetService<IBusiness>();
var ui = new UserInterface(business);

ui.GetData();