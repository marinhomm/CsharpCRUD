public class LanguageUseCase : ILanguageUseCase
{
    private readonly ILanguageRepository _languageRepository;
    private readonly IDtoValidator _dtoValidator;

    public LanguageUseCase(ILanguageRepository languageRepository , IDtoValidator dtoValidator)
    {
        _languageRepository = languageRepository;
        _dtoValidator = dtoValidator;
    }

    public Language Save(LanguageInputDTO data)
    {
        _dtoValidator.Validate(data);

        Language language = new Language
        {
            Name = data.Name,
            ReleaseYear = data.ReleaseYear
        };

        var response = _languageRepository.Save(language);
        return response;
    }

    public List<Language> Get()
    {
        var response = _languageRepository.Get();
        return response;
    }

    public Language? GetById(int id)
    {
        var response = _languageRepository.GetById(id);
        return response;
    }

    public Language Update(int id, LanguageInputDTO data)
    {
        _dtoValidator.Validate(data);

        Language? language = _languageRepository.GetById(id);
        if(language == null)
        {
            throw new Exception("This register does not exist, provide a valid identifier!");
        }

        language.Name = data.Name;
        language.ReleaseYear = data.ReleaseYear;

        var response = _languageRepository.Update(language);
        return response;
    }

    public void Delete(int id)
    {
        Language? language = _languageRepository.GetById(id);
        if(language == null)
        {
            throw new Exception("This register does not exist, provide a valid identifier!");
        }

        _languageRepository.Delete(language);
    }
}