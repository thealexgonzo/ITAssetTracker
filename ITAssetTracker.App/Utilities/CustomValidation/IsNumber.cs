using System.ComponentModel.DataAnnotations;

namespace ITAssetTracker.WebAPI.Utilities.CustomValidation;

public class IsNumber: ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        if (value is int)
            return true;

        return false;
    }
}
