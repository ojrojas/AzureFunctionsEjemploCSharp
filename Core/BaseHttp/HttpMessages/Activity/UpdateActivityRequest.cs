using System;

namespace Core.BaseHttp.HttpMessages.Activity
{
    public class UpdateActivityRequest : RequestMessage
    {
        public string Name { get; set; }
        public DateTime EndDate { get; set; }
    }
}