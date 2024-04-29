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

    [HttpGet]
    [Route("v1/Language/GetById/{id}")]
    public IActionResult GetById(int id)
    {
        try
        {
            var response = _languageUseCase.GetById(id);
            return Ok(response);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpPut]
    [Route("v1/Language/Update/{id}")]
    public IActionResult Update(int id, [FromBody] LanguageInputDTO data)
    {
        try
        {
            var response = _languageUseCase.Update(id, data);
            return Ok(response);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpDelete]
    [Route("v1/Language/Delete/{id}")]
    public IActionResult Delete(int id)
    {
        try
        {
            _languageUseCase.Delete(id);
            return Ok();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}