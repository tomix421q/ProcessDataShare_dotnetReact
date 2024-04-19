namespace api.Interfaces.Live
{
    public interface IMainLiveDataService
    {
        Task<Models.HomeDashboardModel> GetDashboardData();
    }
}