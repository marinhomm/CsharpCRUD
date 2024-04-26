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
}