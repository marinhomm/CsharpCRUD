using System.ComponentModel.DataAnnotations;

public class DtoValidator : IDtoValidator
{
    public void Validate(object dto)
    {
        if(dto == null)
        {
            throw new Exception("All mandatory fields must be entered!");
        }
        
        var results = new List<ValidationResult>();
        var context = new ValidationContext(dto);
        bool isValid = Validator.TryValidateObject(dto, context, results, true);

        if(!isValid)
        {
           foreach(ValidationResult item in results)
           {
                throw new Exception(item.ErrorMessage);
           }
        }
    }
}