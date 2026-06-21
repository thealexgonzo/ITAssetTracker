using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Domain.Common
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
    }
}
