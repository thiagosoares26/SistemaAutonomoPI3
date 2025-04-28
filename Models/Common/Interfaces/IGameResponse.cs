namespace AutoSystem_KingMe.Models.Common.Interfaces
{
    public interface IGameResponse<TEntity>
    {
        List<TEntity> Entities { get; set; }

        TReturn? OnSuccess<TReturn>(Func<List<TEntity>, TReturn> func);
        void OnSuccess(Action<List<TEntity>> func);
    }
}
