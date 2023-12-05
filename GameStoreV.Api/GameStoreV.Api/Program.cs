using GameStore.Api.Entities;
using GameStoreV.Api.Endpoints;


/*
 WebApplication 
    is used to configure the HTTP pipeline and routes
 */

/*
 CreateBuilder
    creates instance of WebApplication with preconfigured defaults 
 */
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGamesEndpoints();

/*
 runs the application in the host
 */
app.Run();
