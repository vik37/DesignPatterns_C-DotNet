using System;
using System.Collections.Generic;
using System.Text;

namespace ObservableDPPart_DeclarativeEventSubscriptionsWithInterface
{
    public interface ISend<TEvent> where TEvent : IEvent
    {
        event EventHandler<TEvent> Sender;
    }
}
