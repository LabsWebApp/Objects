using System.Timers;

namespace MvvmDemo.Models;

internal class TimeModel
{
    private const int Tick = 1000;

    public TimeModel()
    {
        Timer timer = new Timer(Tick);
    }

}