using System;
using Core.Dtos;

namespace Core.BaseHttp.HttpMessages.Activity
{
    public class GetActivityByIdResponse : ResponseMessage
    {
        public GetActivityByIdResponse(Guid correlationId) : base(correlationId) { }
        public ActivityDto ActivityDto { get; set; }
    }
}