using System;

namespace Core.BaseHttp
{
    public class ResponseMessage : BaseMessage  
    {
        public ResponseMessage(Guid correlationId) : base()
        {
            base._correlation = correlationId;
        }

        public ResponseMessage()
        {

        }
    }
}