using MediatorDP_UdemyDesignPatterns_ConsoleApp.RxSamples.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDP_UdemyDesignPatterns_ConsoleApp.RxSamples
{
    public class Actor
    {
        protected EventBroker broker;
        public Actor(EventBroker broker)
        {
            this.broker = broker;
        }
    }
}
