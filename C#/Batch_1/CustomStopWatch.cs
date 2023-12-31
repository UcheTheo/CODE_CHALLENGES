﻿using System.Diagnostics;

namespace Batch_1
{
    public class CustomStopWatch : Stopwatch
    {
        public DateTime? StartAt { get; private set; }
        public DateTime? EndAt { get; private set; }

        public new void Start()
        {
            StartAt = DateTime.Now;
            base.Start();
        }

        public new void Stop() 
        {
            EndAt = DateTime.Now;
            base.Stop();
        }

        public new void Reset()
        {
            StartAt = null;
            EndAt = null;

            base.Reset();
        }

        public new void Restart()
        {
            StartAt = DateTime.Now;
            EndAt = null;

            base.Restart();
        }
    }
}
