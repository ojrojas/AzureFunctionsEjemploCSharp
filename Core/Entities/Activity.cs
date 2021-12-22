using System;
using Core.Interfaces;

namespace Core.Entities
{
    public class Activity : BaseEntity, IAggregateRoot
    {
        public string Name { get; set; }
        public DateTime EndDate { get; set; }
    }
}