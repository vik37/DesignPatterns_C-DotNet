using System;
using System.Collections.Generic;
using System.Text;

namespace ObservableDPPart_DeclarativeEventSubscriptionsWithInterface
{
    public class ButtonPressedEvent : IEvent
    {
        public int NumberOfClicks;
    }
}
