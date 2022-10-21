using BlazorServerDemo.Data.Interfaces;

namespace BlazorServerDemo.Data.Classes
{
    public class ProcessDemo
    {
        private readonly IDemo _demo;

        public ProcessDemo(IDemo demo)
        {
            _demo = demo;
        }

        public int GetDaysInMonth()
        {
            return DateTime.DaysInMonth(_demo.StartupTime.Year, _demo.StartupTime.Month);
        }
    }
}
