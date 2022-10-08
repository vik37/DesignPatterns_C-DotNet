using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDP_UdemyDesignPatterns_ConsoleApp.RxSamples.Events
{
    public class PlayerSentOffEvent : PlayerEvent
    {
        public string Reason { get; set; }
    }
}
