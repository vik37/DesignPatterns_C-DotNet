using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDP_UdemyDesignPatterns_ConsoleApp.ObserverViaSpecialInterfaces
{
    public class Person : IObservable<Event>
    {
        private readonly HashSet<Subscription> subscriptions = new HashSet<Subscription>();
        public IDisposable Subscribe(IObserver<Event> observer)
        {
            var subscription = new Subscription(this, observer);
            subscriptions.Add(subscription);
            return subscription;
        }
        public void FallIll()
        {
            foreach (var s in subscriptions)
            {
                s.Observer.OnNext(new FallsIllEvent { Address = "123 London Road"});
            }
        }
        public class Subscription : IDisposable
        {
            private readonly Person perosn;
            public readonly IObserver<Event> Observer;

            public Subscription(Person perosn, IObserver<Event> observer)
            {
                this.perosn = perosn;
                Observer = observer;
            }
            public void Dispose()
            {
                perosn.subscriptions.Remove(this);
            }
        }
    }
}
