public interface ILanguageRepository
{
    public Language Save(Language language);
    public List<Language> Get();
    public Language? GetById(int id);
    public Language Update(Language language);
    public void Delete(Language language);
}