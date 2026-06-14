using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Utilities
{
    public interface IRequestHandler<TRequest, TResponse>
    {
        Task<TResponse> Handle(TRequest request);
    }
}
