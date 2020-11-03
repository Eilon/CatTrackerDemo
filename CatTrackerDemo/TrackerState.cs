using System;

namespace CatTrackerDemo
{
    internal class TrackerState
    {
        public string[] Results { get; private set; }

        public void Reset()
        {
            Results = null;
            StateChanged?.Invoke();
        }

        public void SetResults(string[] results)
        {
            Results = results;
            StateChanged?.Invoke();
        }

        public event Action StateChanged;
    }
}
