namespace POS.Infrastructure.Persistence.Interfaces;

public interface IUnitOfWork : IDisposable
{
    //Declaración o matricula de nuestra interfaces a nivel repositorio
    ICategoryRepository Category { get; }
    void SaveChanges();
    Task SaveChangesAsync();
}