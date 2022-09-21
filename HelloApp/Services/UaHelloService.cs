using HelloApp.Services.Interfaces;

namespace HelloApp.Services
{
    public class UaHelloService : IHelloService
    {
        public string Message => "Привіт! Мене звати Сергій!";
    }
}
