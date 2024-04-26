public interface ILanguageRepository
{
    public Language Save(Language language);
    public List<Language> Get();
}