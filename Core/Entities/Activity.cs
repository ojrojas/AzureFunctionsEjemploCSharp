using System;
namespace Core.Entities
{
    public class Activity : BaseEntity
    {
        public string Name { get; set; }
        public DateTime EndDate { get; set; }
    }
}