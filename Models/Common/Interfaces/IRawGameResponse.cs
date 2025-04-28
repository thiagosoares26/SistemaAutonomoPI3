namespace AutoSystem_KingMe.Models.Common.Interfaces
{
    public interface IRawGameResponse
    {
        string RawResponse { get; set; }
        List<string> RawListResponse { get; set; }

        TReturn? OnSuccess<TReturn>(Func<string, TReturn> func);
        void OnSuccess(Action<string> func);

    }
}
