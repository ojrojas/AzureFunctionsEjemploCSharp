using System;
using Core.Dtos;

namespace Core.BaseHttp.HttpMessages.Activity
{
    public class UpdateActivityResponse: ResponseMessage
    {
        public UpdateActivityResponse(Guid correlationId): base(correlationId){}
        public ActivityDto ActivityDto {get;set;}
    }
}