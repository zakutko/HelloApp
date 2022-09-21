namespace HelloApp.Services
{
    public class TimeService
    {
        public TimeService()
        {
            Time = DateTime.Now.ToString();
        }
        public string Time { get; set; }
    }
}
