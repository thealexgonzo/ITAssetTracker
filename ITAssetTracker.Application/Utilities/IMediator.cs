using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ITAssetTracker.Application.Utilities
{
    public interface IMediator
    {
        Task<TResponse> Send<TResponse>(IRequest<TResponse> request);
    }
}
