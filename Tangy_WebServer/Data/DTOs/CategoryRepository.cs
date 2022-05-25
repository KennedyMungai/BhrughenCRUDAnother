using Tangy_WebServer.Data;

namespace Tangy_WebServer.Data.DTOs;

public class CategoryRepository : ICategoryRepository
{
    private readonly ApplicationDbContext _db;

    public CategoryRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public CategoryDTO Create(CategoryDTO objDTO)
    {
        Category category = new Category()
        {
            Name = objDTO.Name,
            Id = objDTO.Id,
            CreatedDate = DateTime.Now
        };

        _db.Categories.Add(category);
        _db.SaveChanges();

        return new CategoryDTO()
        {
            Id=category.Id,
            Name=category.Name
        };
    }

    public CategoryDTO Update(CategoryDTO objDTO)
    {

    }

    public int Delete(int id)
    {

    }

    public CategoryDTO Get(int id)
    {

    }

    public IEnumerable<CategoryDTO> GetAll()
    {

    }
}