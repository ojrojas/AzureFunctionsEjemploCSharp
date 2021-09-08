using System;

namespace Core.BaseHttp.HttpMessages.Activity
{
    public class GetActivityByIdRequest : RequestMessage
    {
        public Guid Id { get; set; }
    }
}