public interface ILanguageUseCase
{
    public Language Save(LanguageInputDTO data);
    public List<Language> Get();
    public Language? GetById(int id);
    public Language Update(int id, LanguageInputDTO data);
    public void Delete(int id);
}