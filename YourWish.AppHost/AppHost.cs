var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.YourWish>("yourwish");

builder.Build().Run();
