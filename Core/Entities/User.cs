using System;
using System.ComponentModel.DataAnnotations;
using Core.Interfaces;

namespace Core.Entities
{
    public class User : BaseEntity, IAggregateRoot
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}