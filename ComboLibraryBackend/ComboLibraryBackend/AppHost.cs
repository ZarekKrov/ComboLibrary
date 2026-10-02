var builder = DistributedApplication.CreateBuilder(args);

builder.AddJavaScriptApp("Front", "../../ComboLibraryFronted", runScriptName: "start")
    .WithHttpEndpoint(env: "PORT")
    .WithExternalHttpEndpoints();

builder.Build().Run();