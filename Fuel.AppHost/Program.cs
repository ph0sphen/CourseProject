var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Fuel>("fuel");

builder.Build().Run();
