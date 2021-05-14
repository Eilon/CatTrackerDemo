using CatTrackerWebUILibrary.Models;
using System;
using System.Collections.Generic;

namespace CatTrackerDemo
{
    public class TrackerState
    {
        public IList<CatTrackerResult> Results { get; private set; }

        public void Reset()
        {
            Results = null;
            StateChanged?.Invoke();
        }

        public void SetResults(IList<CatTrackerResult> results)
        {
            Results = results;
            StateChanged?.Invoke();
        }

        public event Action StateChanged;
    }
}
