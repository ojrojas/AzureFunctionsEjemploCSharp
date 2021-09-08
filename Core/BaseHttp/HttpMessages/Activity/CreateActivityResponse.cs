using System;
using Core.BaseHttp;
using Core.Dtos;

namespace Core.BaseHttp.HttpMessages.Activity
{
    public class CreateActivityResponse : ResponseMessage
    {
        public CreateActivityResponse(Guid correlationId) : base(correlationId) { }
        public ActivityDto ActivityDto {get;set;}
    }
}