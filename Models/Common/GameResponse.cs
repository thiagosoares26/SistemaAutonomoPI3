using AutoSystem_KingMe.Models.Common.Interfaces;

namespace AutoSystem_KingMe.Models.Common
{
    public class GameResponse<TEntity> : IRawGameResponse, IOneGameResponse<TEntity>, IGameResponse<TEntity>
    {
        public bool IsSuccess { get => string.IsNullOrWhiteSpace(ErrorMessage); }
        public string? ErrorMessage { get; set; }
        public List<TEntity> Entities { get; set; } = new List<TEntity>();
        public TEntity Entity { get; set; }
        public string RawResponse { get; set; }


        private bool errorThrowed { get; set; } = false;

        #region IGameResponse

        public TReturn? OnSuccess<TReturn>(Func<List<TEntity>, TReturn> func)
        {
            if (IsSuccess) return func.Invoke(Entities);
            else if (!errorThrowed) ThrowError();

            return default;
        }
        public void OnSuccess(Action<List<TEntity>> func)
        {
            if (IsSuccess) func.Invoke(Entities);
            else if (!errorThrowed) ThrowError();
        }

        #endregion

        #region IRawGameResponse

        public TReturn? OnSuccess<TReturn>(Func<string, TReturn> func)
        {
            if (IsSuccess) return func.Invoke(RawResponse);
            else if (!errorThrowed) ThrowError();

            return default;
        }
        public void OnSuccess(Action<string> func)
        {
            if (IsSuccess) func.Invoke(RawResponse);
            else if (!errorThrowed) ThrowError();
        }

        #endregion

        #region IOneGameResponse

        public TReturn? OnSuccess<TReturn>(Func<TEntity, TReturn> func)
        {
            if (IsSuccess) return func.Invoke(Entity);
            else if (!errorThrowed) ThrowError();

            return default;
        }
        public void OnSuccess(Action<TEntity> func)
        {
            if (IsSuccess) func.Invoke(Entity);
            else if (!errorThrowed) ThrowError();
        }

        #endregion

        private void ThrowError()
        {
            errorThrowed = true;
            MessageBox.Show(ErrorMessage, "Atenção", MessageBoxButtons.OK);
        }
    }
}
