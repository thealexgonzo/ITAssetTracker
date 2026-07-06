using ITAssetTracker.Application.Models.Mail;

namespace ITAssetTracker.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
