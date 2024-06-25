namespace Domain.Primitives;

public interface IUnitOfWorker
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}