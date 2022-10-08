using MediatorDP_UdemyDesignPatterns_ConsoleApp.RxSamples.Events;
using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Text;

namespace MediatorDP_UdemyDesignPatterns_ConsoleApp.RxSamples
{
    public class FootballPlayer : Actor
    {
        public string Name { get; set; }
        public int GoalScored { get; set; } = 0;
        public void Score()
        {
            GoalScored++;
            broker.Publish(new PlayerScoreEvent { Name = Name, GoalsScored = GoalScored });
        }
        public void AssaultReferee()
        {
            broker.Publish(new PlayerSentOffEvent { Name = Name, Reason = "violence" });
        }
        public FootballPlayer(EventBroker broker, string name) : base(broker)
        {
            Name = name;
            broker.OfType<PlayerScoreEvent>()
                .Where(ps => !ps.Name.Equals(name))
                .Subscribe(
                ps => Console.WriteLine($"{Name}: Nicely done, {ps.Name}! It's your {ps.GoalsScored}"));

            broker.OfType<PlayerSentOffEvent>()
                .Where(ps => !ps.Name.Equals(Name))
                .Subscribe(ps => Console.WriteLine($"{Name}: See you in the lockers, {ps.Name}"));
        }
    }
}
