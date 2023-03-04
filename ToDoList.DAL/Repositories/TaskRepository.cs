using ToDoList.DAL.Interfaces;
using ToDoList.Domain.Entity;

namespace ToDoList.DAL.Repositories;

public class TaskRepository : IBaseRepository<TaskEntity>
{
    private readonly AppDbContext _appDbContext;

    public TaskRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task Create(TaskEntity entity)
    {
        await _appDbContext.Tasks.AddAsync(entity);
        await _appDbContext.SaveChangesAsync();
    }

    public IQueryable<TaskEntity> GetAll()
    {
        return _appDbContext.Tasks;
    }

    public async Task Delete(TaskEntity entity)
    {
        _appDbContext.Tasks.Remove(entity);
        await _appDbContext.SaveChangesAsync();
    }

    public async Task<TaskEntity> Update(TaskEntity entity)
    {
        _appDbContext.Tasks.Update(entity);
        await _appDbContext.SaveChangesAsync();

        return entity;
    }
}