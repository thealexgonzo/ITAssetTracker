namespace ITAssetTracker.Application.Contracts.Persistence
{
    public interface IUnitOfWork
    {
        Task Commit();
        Task RollBack();
    }
}
