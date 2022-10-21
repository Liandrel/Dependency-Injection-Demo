using BlazorServerDemo.Data.Interfaces;

namespace BlazorServerDemo.Data.Classes
{
    public class Demo : IDemo, ILocalDemo
    {
        public DateTime StartupTime { get; init; }

        public Demo()
        {
            StartupTime = DateTime.Now;
        }
    }
}
