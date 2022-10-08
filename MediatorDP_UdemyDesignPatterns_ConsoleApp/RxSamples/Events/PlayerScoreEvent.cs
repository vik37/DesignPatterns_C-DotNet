using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDP_UdemyDesignPatterns_ConsoleApp.RxSamples.Events
{
    public class PlayerScoreEvent : PlayerEvent
    {
        public int GoalsScored { get; set; }
    }
}
