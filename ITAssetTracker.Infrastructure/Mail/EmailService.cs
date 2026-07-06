using ITAssetTracker.Application.Contracts.Infrastructure;
using ITAssetTracker.Application.Models.Mail;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace ITAssetTracker.Infrastructure.Mail;

public class EmailService : IEmailService
{
    private readonly EmailSettings mailSettings;

    public EmailService(IOptions<EmailSettings> mailSettings)
    {
        this.mailSettings = mailSettings.Value;
    }

    public async Task<bool> SendEmail(Email email)
    {
        SendGridClient client = new SendGridClient(mailSettings.ApiKey);
        string subject = email.Subject;
        EmailAddress to = new EmailAddress(email.To);
        string emailBody = email.Body;

        EmailAddress from = new EmailAddress
        {
            Email = mailSettings.FromAddress,
            Name = mailSettings.FromName
        };

        SendGridMessage sendGridMessage = MailHelper.CreateSingleEmail(from, to, subject, emailBody, emailBody);
        Response response = await client.SendEmailAsync(sendGridMessage);

        if(response.StatusCode == System.Net.HttpStatusCode.Accepted || response.StatusCode == System.Net.HttpStatusCode.OK)
        {
            return true;
        }

        return false;
    }
}
