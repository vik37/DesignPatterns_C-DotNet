using System;
using System.Collections.Generic;
using System.Reactive.Subjects;
using System.Text;

namespace MediatorDP_UdemyDesignPatterns_ConsoleApp.RxSamples.Events
{
    public class EventBroker : IObservable<PlayerEvent>
    {
        private Subject<PlayerEvent> subscriptions = new Subject<PlayerEvent> ();
        public IDisposable Subscribe(IObserver<PlayerEvent> observer)
        {
            return subscriptions.Subscribe (observer);
        }
        public void Publish(PlayerEvent pe)
        {
            subscriptions.OnNext(pe);
        }
    }
}
