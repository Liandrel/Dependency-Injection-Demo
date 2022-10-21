using BlazorServerDemo.Data.Interfaces;

namespace BlazorServerDemo.Data.Classes
{
    public class UtcDemo : IDemo, IUtcDemo
    {
        public DateTime StartupTime { get; init; }

        public UtcDemo()
        {
            StartupTime = DateTime.UtcNow;
        }
    }
}
