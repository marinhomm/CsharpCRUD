using Microsoft.AspNetCore.Mvc;

public class LanguageController : Controller
{
    private readonly ILanguageUseCase _languageUseCase;

    public LanguageController(ILanguageUseCase languageUseCase)
    {
        _languageUseCase = languageUseCase;
    }

    [HttpPost]
    [Route("v1/Language/Save")]
    public IActionResult Save([FromBody] LanguageInputDTO data)
    {
        try
        {
            var response = _languageUseCase.Save(data);
            return CreatedAtAction("Save", response);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet]
    [Route("v1/Language/Get")]
    public IActionResult Get()
    {
        try
        {
            var response = _languageUseCase.Get();
            return Ok(response);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}