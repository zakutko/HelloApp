using HelloApp.Services.Interfaces;

namespace HelloApp.Services.Classes
{
    public class RandomCounter : ICounter
    {
        static Random rnd = new Random();
        private int _value;
        public RandomCounter()
        {
            _value = rnd.Next(0, 1000000);
        }
        public int Value
        {
            get { return _value; }
        }
    }
}
