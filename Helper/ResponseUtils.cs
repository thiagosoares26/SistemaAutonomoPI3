using AutoSystem_KingMe.Models.Common;
using AutoSystem_KingMe.Models.Common.Interfaces;
using System.Runtime.CompilerServices;

namespace AutoSystem_KingMe.Helper
{
    public static class ResponseUtils
    {
        public static IGameResponse<TEntity> HandleReponse<TEntity>(this string input) where TEntity : EntityBase, new()
        {
            var response = new GameResponse<TEntity>();
            if (input.StartsWith("ERRO"))
            {
                response.ErrorMessage = input.Substring(5);
                return response;
            }

            var values = input.Split("\r\n");
            foreach (var value in values) {
                var entity = new TEntity();
                entity.FillReponse(value);

                response.Entities.Add(entity);
            }

            return response;
        }

        public static IRawGameResponse HandleRawResponse(this string input) 
        {
            var response = new GameResponse<string>();
            if (input.StartsWith("ERRO"))
            {
                response.ErrorMessage = input.Substring(5);
                return response;
            }

            response.RawResponse = input;
            return response;
        }

        public static IOneGameResponse<TEntity> HandleOneResponse<TEntity>(this string input) where TEntity : EntityBase, new ()
        {
            var response = new GameResponse<TEntity>();
            if (input.StartsWith("ERRO"))
            {
                response.ErrorMessage = input.Substring(5);
                return response;
            }

            var value = input.Split("\r\n").FirstOrDefault();
            
            var entity = new TEntity();
            entity.FillReponse(value);
            response.Entity = entity;

            return response;
        }

    }
}
