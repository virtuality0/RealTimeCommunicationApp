namespace RealTimeCommunicationApp.Services.Interfaces
{
    public interface IUnitOfWork<T> : IDisposable where T : class
    {
        IGenericRepo<T> GenericRepo { get; }
        void Commit();
    }
}
