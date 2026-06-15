using ITAssetTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Contracts.Repositories
{
    public interface ICategoryRepository: IAsyncRepository<Category>
    {
    }
}
