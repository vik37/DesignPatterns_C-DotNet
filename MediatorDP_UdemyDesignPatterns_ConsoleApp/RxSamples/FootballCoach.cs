using MediatorDP_UdemyDesignPatterns_ConsoleApp.RxSamples.Events;
using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Text;

namespace MediatorDP_UdemyDesignPatterns_ConsoleApp.RxSamples
{
    public class FootballCoach : Actor
    {
        public FootballCoach(EventBroker broker) : base(broker)
        {
            broker.OfType<PlayerScoreEvent>()
                .Subscribe(pe =>
                {
                    if (pe.GoalsScored < 3)
                        Console.WriteLine($"Coach: Well done, {pe.Name}");
                });
            broker.OfType<PlayerSentOffEvent>()
                .Subscribe(pe =>
                {
                    if (pe.Reason == "violence")
                        Console.WriteLine($"Coach: How could you, {pe.Name}");
                });
        }
    }
}
