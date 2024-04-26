public interface ILanguageUseCase
{
    public Language Save(LanguageInputDTO data);
    public List<Language> Get();
}