using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
namespace WebApplication1.Controllers;

public static class Endpoints
{
    public static void MapHelloControllerEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/HelloController").WithTags(nameof(HelloController));

        group.MapGet("/", () =>
        {
            return new [] { new HelloController() };
        })
        .WithName("GetAllHelloControllers")
        .WithOpenApi();

        group.MapGet("/{id}", (int id) =>
        {
            //return new HelloController { ID = id };
        })
        .WithName("GetHelloControllerById")
        .WithOpenApi();

        group.MapPut("/{id}", (int id, HelloController input) =>
        {
            return TypedResults.NoContent();
        })
        .WithName("UpdateHelloController")
        .WithOpenApi();

        group.MapPost("/", (HelloController model) =>
        {
            //return TypedResults.Created($"/api/HelloControllers/{model.ID}", model);
        })
        .WithName("CreateHelloController")
        .WithOpenApi();

        group.MapDelete("/{id}", (int id) =>
        {
            //return TypedResults.Ok(new HelloController { ID = id });
        })
        .WithName("DeleteHelloController")
        .WithOpenApi();
    }
}
