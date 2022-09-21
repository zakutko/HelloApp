using HelloApp.Services.Interfaces;

namespace HelloApp.Services.Classes
{
    public class ValueStorage : IGenerator, IReader
    {
        int value;
        public int GenerateValue()
        {
            value = new Random().Next();
            return value;
        }
        public int ReadValue()
        {
            return value;
        }
    }
}
