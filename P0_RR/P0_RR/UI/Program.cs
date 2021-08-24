using UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

string ConnectionString = configuration.GetConnectionString("CMDBP0");

DbContextOptions<CMDBP0Context> options = new DbContextOptionsBuilder<CMDBP0Context>()
    .UseSqlServer(connectionString)
    .Options;

var context = new CMDBP0Context(options);

IMenu menu = new MainMenu();
menu.Start();