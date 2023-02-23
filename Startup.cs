using System;

public void ConfigureServices(IServiceCollection services)
{
    string connectionString = Configuration.GetConnectionString("MyConnectionString");
    services.AddDbContext<MyDbContext>(options => options.UseSqlServer(connectionString));
}