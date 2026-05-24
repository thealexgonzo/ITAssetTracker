using ITAssetTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.ServiceInterfaces;

public interface IAssetTypeService
{
    Result<List<AssetType>> GetAll();
}
