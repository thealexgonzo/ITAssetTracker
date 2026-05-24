using System.ComponentModel.DataAnnotations;

namespace ITAssetTracker.MVC.Utilities.CustomValidation;

public class IsNumber: ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        if (value is int)
            return true;

        return false;
    }
}
