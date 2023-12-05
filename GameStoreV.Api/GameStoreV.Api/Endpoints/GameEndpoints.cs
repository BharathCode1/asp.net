﻿using GameStore.Api.Entities;
using GameStoreV.Api.Repositories;

namespace GameStoreV.Api.Endpoints
{
    public static class GameEndpoints
    {
        const string GetGameEndPointName = "GetGame";

        //this key work before interface extends the method
        public static RouteGroupBuilder MapGamesEndpoints(this IEndpointRouteBuilder routes)
        {
            InMemGamesRepository repository = new();

            var group = routes.MapGroup("/games");

            /*
             "/" -> root
             () => "Hello World"! (lambda function)
             */
            group.MapGet("/", () => repository.GetAll());

            group.MapGet("/{id}", (int id) =>
            {
                Game? game = repository.Get(id);
                return game is not null ? Results.Ok(game) : null;
            })
            .WithName(GetGameEndPointName);

            group.MapPost("/", (Game game) =>
            {
                repository.Create(game);
                return Results.CreatedAtRoute(GetGameEndPointName, new { id = game.Id }, game);
            });

            group.MapPut("/{id}", (int id, Game updatedGame) =>
            {
                Game? existingGame = repository.Get(id);

                if (existingGame is null)
                {
                    return Results.NotFound();
                }

                existingGame.Name = updatedGame.Name;
                existingGame.Genre = updatedGame.Genre;
                existingGame.Price = updatedGame.Price;
                existingGame.ReleaseDate = updatedGame.ReleaseDate;
                existingGame.ImageUri = updatedGame.ImageUri;

                repository.Update(existingGame);

                return Results.NoContent();

            });

            group.MapDelete("/{id}", (int id) =>
            {
                Game? existingGame = repository.Get(id);

                if (existingGame is not null)
                {
                    repository.Delete(id);
                }
                return Results.NoContent();
            });

            return group;
        }
    }
}
