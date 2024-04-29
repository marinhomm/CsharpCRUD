using CsharpCrud.Data;

public class LanguageRepository : ILanguageRepository
{
    private readonly ApplicationDbContext _context;

    public LanguageRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Language Save(Language language)
    {
        var response = _context.Language.Add(language);
        _context.SaveChanges();
        return response.Entity;
    }

    public List<Language> Get()
    {
        var response = _context.Language.ToList();
        return response;
    }

    public Language? GetById(int id)
    {
        var response = _context.Language.Find(id);
        return response;
    }

    public Language Update(Language language)
    {
        _context.Language.Update(language);
        _context.SaveChanges();
        return language;
    }

    public void Delete(Language language)
    {
        _context.Language.Remove(language);
        _context.SaveChanges();
    }
}