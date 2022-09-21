using HelloApp.Services.Interfaces;

namespace HelloApp.Services
{
    public class EnHelloService : IHelloService
    {
        public string Message => "Hello! My name is Serhii!";
    }
}
