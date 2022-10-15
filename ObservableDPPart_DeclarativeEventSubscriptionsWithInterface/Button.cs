using System;
using System.Collections.Generic;
using System.Text;

namespace ObservableDPPart_DeclarativeEventSubscriptionsWithInterface
{
    public class Button : ISend<ButtonPressedEvent>
    {
        public event EventHandler<ButtonPressedEvent> Sender;
        public void Fire(int clicks)
        {
            Sender?.Invoke(this,new ButtonPressedEvent
            {
                NumberOfClicks = clicks,
            });
        }
    }
}
