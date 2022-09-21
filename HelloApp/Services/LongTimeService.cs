using HelloApp.Services.Interfaces;

namespace HelloApp.Services
{
    public class LongTimeService : ITimeService
    {
        public string GetTime()
        {
            return DateTime.Now.ToLongTimeString();
        }
    }
}
