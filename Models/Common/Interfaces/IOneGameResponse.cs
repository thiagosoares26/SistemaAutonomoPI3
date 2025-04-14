namespace AutoSystem_KingMe.Models.Common.Interfaces
{
    public interface IOneGameResponse<TEntity>
    {
        TEntity Entity {  get; set; }

        TReturn? OnSuccess<TReturn>(Func<TEntity, TReturn> func);
        void OnSuccess(Action<TEntity> func);
    }
}
