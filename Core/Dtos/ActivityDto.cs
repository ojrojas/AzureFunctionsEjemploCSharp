using System;
using Core.Entities;

namespace Core.Dtos
{
    public class ActivityDto : BaseEntity
    {
        public string Name { get; set; }
        public DateTime EndDate { get; set; }
    }
}