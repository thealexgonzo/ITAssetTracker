using ITAssetTracker.Domain.Exceptions;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;

namespace ITAssetTracker.Domain.ValueObjects;

[Owned]
public sealed record Email
{
    public string Value { get; }

    public Email(string value)
    {
        if(!MailAddress.TryCreate(value, out _))
        {
            throw new BusinessRuleExceptions("Invalid email");               
        }

        Value = value;
    }

    public override string ToString() => Value;
}
