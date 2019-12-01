using System;

namespace Online_Store.Domain.Interfaces
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