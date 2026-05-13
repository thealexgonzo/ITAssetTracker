using ITAssetTracker.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Interfaces;

public interface IAssetTypeService
{
    Result<List<AssetType>> GetAll();
}
