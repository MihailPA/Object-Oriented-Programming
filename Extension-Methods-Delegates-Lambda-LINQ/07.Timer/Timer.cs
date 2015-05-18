//Problem 7. Timer
//Using delegates write a class Timer that can execute certain method at each t seconds.


using System;
using System.Threading;

namespace _07.Timer
{

    public delegate void TimerDelegate();

    public class Timer
    {
        private int interval;
        private bool runTimer;
        private TimerDelegate timerDelegate;
        private Thread timerThread;

        public Timer(TimerDelegate timerEvent, int interval)
        {
            this.Interval = interval;
            this.timerDelegate = timerEvent;
            this.runTimer = true;
            this.timerThread = new Thread(new ThreadStart(this.StartTimer));
        }

        public int Interval
        {
            get { return this.interval; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                this.interval = value;
            }
        }

        private void StartTimer()
        {
            while (this.runTimer)
            {
                Thread.Sleep((int)interval);
                if (runTimer)
                {
                    timerDelegate();
                }
            }
        }

        public void Start()
        {
            timerThread.Start();
        }

        public void Stop()
        {
            this.runTimer = false;
        }
    }
}
