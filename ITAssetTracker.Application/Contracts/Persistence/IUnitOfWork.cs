using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Contracts.Persistence
{
    public interface IUnitOfWork
    {
        Task Commit();
        Task RollBack();
    }
}
