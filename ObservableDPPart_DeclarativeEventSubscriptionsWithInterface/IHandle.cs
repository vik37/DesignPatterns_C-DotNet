using System;
using System.Collections.Generic;
using System.Text;

namespace ObservableDPPart_DeclarativeEventSubscriptionsWithInterface
{
    public interface IHandle<TEvent> where TEvent : IEvent
    {
        void Handle(object sender, TEvent args);
    }
}
