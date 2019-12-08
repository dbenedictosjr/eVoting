﻿using System;

namespace OSPI.Inventory.Domain.Interfaces
{
    public interface IAuditableRepository
    {
        Guid CreatedBy { get; set; }

        DateTime CreatedDate { get; set; }

        Guid UpdatedBy { get; set; }

        DateTime UpdatedDate { get; set; }

        byte[] RowVersion { get; set; }
    }
}