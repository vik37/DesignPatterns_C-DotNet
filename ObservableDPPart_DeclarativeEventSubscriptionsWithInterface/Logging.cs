using System;
using System.Collections.Generic;
using System.Text;

namespace ObservableDPPart_DeclarativeEventSubscriptionsWithInterface
{
    public class Logging : IHandle<ButtonPressedEvent>
    {
        public void Handle(object sender, ButtonPressedEvent args)
        {
            Console.WriteLine($"Button was clicked {args.NumberOfClicks} times");
        }
    }
}
