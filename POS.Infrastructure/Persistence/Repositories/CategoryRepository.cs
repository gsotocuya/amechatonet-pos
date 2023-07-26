using POS.Domain.Entities;
using POS.Infrastructure.Commons.Bases.Request;
using POS.Infrastructure.Commons.Bases.Response;
using POS.Infrastructure.Persistence.Contexts;
using POS.Infrastructure.Persistence.Interfaces;

namespace POS.Infrastructure.Persistence.Repositories;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    private readonly POSContext _context;

    public CategoryRepository(POSContext context)
    {
        _context = context;
    }

    public async Task<BaseEntityResponse<Category>> ListCategories(BaseFiltersRequest filters)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Category>> ListSelectCategories()
    {
        throw new NotImplementedException();
    }

    public async Task<Category> CategoryById(int categoryId)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> RegisterCategory(Category category)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> EditCategory(Category category)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> RemoveCategory(int categoryId)
    {
        throw new NotImplementedException();
    }
}