using HelloApp.Services.Interfaces;

namespace HelloApp.Services
{
    public class ShortTimeService : ITimeService
    {
        public string GetTime()
        {
            return DateTime.Now.ToShortTimeString();
        }
    }
}
