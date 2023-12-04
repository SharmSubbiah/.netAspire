var builder = DistributedApplication.CreateBuilder(args);
var cache = builder.AddRedisContainer("rediscache");

var api = builder.AddProject<Projects.AspireAPI>("aspireapi");

builder.AddProject<Projects.AspireApp>("aspireapp")
    .WithReference(api)
    .WithReference(cache);


builder.Build().Run();
