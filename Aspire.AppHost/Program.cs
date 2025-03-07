using Aspire.Hosting;

var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

//var apiService = builder.AddProject<Projects.Aspire_ApiService>("apiservice");

//builder.AddProject<Projects.Aspire_Web>("webfrontend")
//    .WithExternalHttpEndpoints()
//    .WithReference(cache)
//    .WaitFor(cache)
//    .WithReference(apiService)
//    .WaitFor(apiService);

//col cal
var colcalDb = builder
    .AddSqlServer("sql-server")
    .WithLifetime(ContainerLifetime.Persistent)
    .WithDataVolume()
    //.WithContainerRuntimeArgs("--name", "sql-server", "-p", "1433:1433")
    .AddDatabase("colcalDb");

var api = builder.AddProject<Projects.SFA_DAS_CollectionCalendar_InnerAPI>("colcalapi")
    .WithExternalHttpEndpoints()
    .WithReference(colcalDb)
    .WaitFor(colcalDb);


//api.WithEnvironment()


builder.Build().Run();
