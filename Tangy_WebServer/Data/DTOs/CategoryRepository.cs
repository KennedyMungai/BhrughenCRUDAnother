using Tangy_WebServer.Data;
using AutoMapper;

namespace Tangy_WebServer.Data.DTOs;

public class CategoryRepository : ICategoryRepository
{
    private readonly ApplicationDbContext _db;
    private readonly IMapper _mapper;

    public CategoryRepository(ApplicationDbContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public CategoryDTO Create(CategoryDTO objDTO)
    {
        var obj = _mapper.Map<CategoryDTO, Category>(objDTO);
        
        var addedObj = _db.Categories.Add(obj);
        _db.SaveChanges();

        return _mapper.Map<Category, CategoryDTO>(addedObj.Entity);
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