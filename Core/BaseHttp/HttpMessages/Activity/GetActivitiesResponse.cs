using System;
using System.Collections.Generic;
using Core.Dtos;

namespace Core.BaseHttp.HttpMessages.Activity
{
    public class GetActivitiesResponse : ResponseMessage
    {
        public GetActivitiesResponse(Guid correlationId): base(correlationId){}
        public IReadOnlyList<ActivityDto> Activities {get;set;}
    }
}