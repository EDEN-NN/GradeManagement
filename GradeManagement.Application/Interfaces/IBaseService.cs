namespace GradeManagement.Application.Interfaces;

public interface IBaseService<T>
{
    public Task<Guid> Create(T Entity);
    public Task<T> Update(T Entity);
    public Task<T> FindByID(Guid Id);
    public Task<IEnumerable<T>> FindAll();
    public Task Delete();
}