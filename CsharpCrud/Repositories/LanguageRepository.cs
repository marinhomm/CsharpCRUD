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
}