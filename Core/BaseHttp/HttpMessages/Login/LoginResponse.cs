using System;

namespace Core.BaseHttp.HttpMessages.Login
{
    public class LoginResponse : ResponseMessage
    {
        public LoginResponse(Guid correlation) : base(correlation) { }

        public string Token { get; set; }
    }
}