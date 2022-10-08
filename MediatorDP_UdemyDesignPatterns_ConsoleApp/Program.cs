using Autofac;
using Autofac.Core.Activators.Reflection;
using MediatorDP_UdemyDesignPatterns_ConsoleApp.Chat_Rooms;
using MediatorDP_UdemyDesignPatterns_ConsoleApp.MediatR_Demo;
using MediatorDP_UdemyDesignPatterns_ConsoleApp.RxSamples;
using MediatorDP_UdemyDesignPatterns_ConsoleApp.RxSamples.Events;
using MediatR;
using System;
using System.Threading.Tasks;

namespace MediatorDP_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        //static void Main(string[] args)
        //{ 
        #region Chat Room
        //var room = new ChatRoom();

        //var jane = new Person("Jane");
        //var john = new Person("John");

        //room.Join(john);
        //room.Join(jane);

        //john.Say("Hi");
        //jane.Say("Well, Hallo There");

        //var simon = new Person("Simon");
        //room.Join(simon);
        //simon.Say("Hi everyone! ");

        //jane.PrivateMessage("Simon", "Glad you could join us!");
        #endregion


        #region Event Broker
        //var cb = new ContainerBuilder();
        //cb.RegisterType<EventBroker>().SingleInstance();
        //cb.RegisterType<FootballCoach>().SingleInstance();
        //cb.Register((c, p) =>
        //    new FootballPlayer(
        //        c.Resolve<EventBroker>(),
        //        p.Named<string>("name")
        //    ));
        //using(var c = cb.Build())
        //{
        //    var coach = c.Resolve<FootballCoach>();
        //    var player1 = c.Resolve<FootballPlayer>(new NamedParameter("name","John"));
        //    var player2 = c.Resolve<FootballPlayer>(new NamedParameter("name", "Chris"));

        //    player1.Score();
        //    player1.Score();
        //    player1.Score();
        //    player1.AssaultReferee();
        //    player2.Score();
        //}
        #endregion

        //    Console.ReadLine();
        //}

        #region MediatR
        static async Task Main(string[] args)
        {            
            var cb = new ContainerBuilder();
            cb.RegisterType<Mediator>()
                .As<IMediator>()
                .SingleInstance();

            cb.Register<ServiceFactory>(ctx =>
            {
                var c = ctx.Resolve<IComponentContext>();
                return t => c.Resolve(t);
            });

            cb.RegisterAssemblyTypes(typeof(Program).Assembly)
                .AsImplementedInterfaces();

            var container = cb.Build();
            var mediator = container.Resolve<IMediator>();
            var response = await mediator.Send(new PingCommand());
            Console.WriteLine($"We got a response at {response.Timestamp}");
            
            Console.ReadLine();
        }
        #endregion
    }
}
