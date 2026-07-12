using ITAssetTracker.Domain.Exceptions;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace ITAssetTracker.Domain.ValueObjects;

[Owned]
public sealed record Phone
{
    public string Value { get; }

    public Phone(string value)
    {
        value = value.Replace(" ", "")
                     .Replace("-", "");

        if(!Regex.IsMatch(value, @"^(?:\+44|0)\d{10}$"))
        {
            throw new BusinessRuleExceptions("Invalid UK phone number.");
        }

        Value = value;
    }

    public override string ToString() => Value;
}
