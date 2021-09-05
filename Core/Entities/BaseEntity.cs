using System;

namespace Core.Entities
{
    public class BaseEntity
    {
        public virtual Guid Id { get; protected set; }
        public virtual Guid CreatedBy { get; set; }
        public virtual Guid ModifiedBy { get; set; }
        public virtual DateTime CreatedOn { get; set; }
        public virtual DateTime ModifiedOn { get; set; }
    }
}