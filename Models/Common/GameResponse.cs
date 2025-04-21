using AutoSystem_KingMe.Models.Common.Interfaces;

namespace AutoSystem_KingMe.Models.Common
{
    public class GameResponse<TEntity> : IRawGameResponse, IOneGameResponse<TEntity>, IGameResponse<TEntity>
    {
        public bool IsSuccess { get => string.IsNullOrWhiteSpace(ErrorMessage); }
        public string? ErrorMessage { get; set; }
        public List<string> RawListResponse { get; set; } = new List<string>();
        public List<TEntity> Entities { get; set; } = new List<TEntity>();

        public TEntity Entity { get; set; }
        public string RawResponse { get; set; }


        private bool throwError { get; set; }

        public GameResponse(bool throwError = true)
        {
            this.throwError = throwError;
        }

        #region IGameResponse

        public TReturn? OnSuccess<TReturn>(Func<List<TEntity>, TReturn> func)
        {
            if (IsSuccess) return func.Invoke(Entities);
            else if (throwError) ThrowError();

            return default;
        }
        public void OnSuccess(Action<List<TEntity>> func)
        {
            if (IsSuccess) func.Invoke(Entities);
            else if (throwError) ThrowError();
        }

        #endregion

        #region IRawGameResponse

        public TReturn? OnSuccess<TReturn>(Func<string, TReturn> func)
        {
            if (IsSuccess) return func.Invoke(RawResponse);
            else if (throwError) ThrowError();

            return default;
        }
        public void OnSuccess(Action<string> func)
        {
            if (IsSuccess) func.Invoke(RawResponse);
            else if (throwError) ThrowError();
        }

        #endregion

        #region IOneGameResponse

        public TReturn? OnSuccess<TReturn>(Func<TEntity, TReturn> func)
        {
            if (IsSuccess) return func.Invoke(Entity);
            else if (throwError) ThrowError();

            return default;
        }
        public void OnSuccess(Action<TEntity> func)
        {
            if (IsSuccess) func.Invoke(Entity);
            else if (throwError) ThrowError();
        }

        #endregion

        private void ThrowError()
        {
            throwError = false;
            MessageBox.Show(ErrorMessage, "Atenção", MessageBoxButtons.OK);
        }
    }
}
