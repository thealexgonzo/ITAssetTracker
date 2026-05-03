using ITAssetTracker.Application.Interfaces;
using ITAssetTracker.Application.Services;
using ITAssetTracker.Infrastructure.Interfaces;
using ITAssetTracker.Infrastructure.Repositories.EntityFramework;

namespace ITAssetTracker.MVC.Extensions;

public static class DIRegistrationExtensions
{
    public static WebApplicationBuilder AddSupportTicketRepositories(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<ISupportTicketService, SupportTicketService>();
        builder.Services.AddScoped<ISupportTicketRepository, EFSupportTicketRepository>();
        return builder;
    }
}
