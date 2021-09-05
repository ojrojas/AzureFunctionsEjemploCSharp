using Core.BaseHttp;

namespace Core.BaseHttp.HttpMessages.Login
{
    public class LoginRequest : RequestMessage
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}