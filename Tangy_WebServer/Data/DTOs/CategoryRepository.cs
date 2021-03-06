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
        obj.CreatedDate = DateTime.Now;
        var addedObj = _db.Categories.Add(obj);
        _db.SaveChanges();

        return _mapper.Map<Category, CategoryDTO>(addedObj.Entity);
    }

    public CategoryDTO Update(CategoryDTO objDTO)
    {
        var objFromDb = _db.Categories.FirstOrDefault(u => u.Id == objDTO.Id);

        if(objFromDb is not null)
        {
            objFromDb.Name = objDTO.Name;
            _db.Categories.Update(objFromDb);
            _db.SaveChanges();
            return _mapper.Map<Category, CategoryDTO>(objFromDb);
        };

        return objDTO;
    }

    public int Delete(int id)
    {
        var obj = _db.Categories.FirstOrDefault(u => u.Id == id);

        if (obj is not null)
        {
            _db.Categories.Remove(obj);
            return _db.SaveChanges();
        }

        return 0;
    }

    public CategoryDTO Get(int id)
    {
        var obj = _db.Categories.FirstOrDefault(c => c.Id == id);

        if(obj is not null)
        {
            return _mapper.Map<Category, CategoryDTO>(obj);
        }

        return new CategoryDTO();
    }

    public IEnumerable<CategoryDTO> GetAll()
    {
        return _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryDTO>>(_db.Categories);
    }
}