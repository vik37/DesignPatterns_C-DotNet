using Autofac;
using SingletonDP_UdemyDesignPatterns_ConsoleApp;
using SingletonDP_UdemyDesignPatterns_ConsoleApp.Singleton_Implementation;
using SingletonDP_UdemyDesignPatterns_ConsoleApp.Singleton_Implementation.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestDP_Methods.Singleton_Test
{
    public class SingletonDP_Test
    {       
        [Fact]
        public void IsSingleton()
        {
            var db = SingletonDatabase.Instance;
            var db2 = SingletonDatabase.Instance;
            Assert.Same(db, db2);
            Assert.Equal(1,SingletonDatabase.Count);
        }
        [Fact]
        public void SingletonTotalPopulationTest()
        {
            var rf = new SingletonRecordFinder();
            var names = new string[] { "Seoul", "Mumbai" };
            int tp = rf.GetTotalPopulation(names);
            Assert.Equal(31850000,tp);
        }
        [Fact]
        public void ConfigurablePopulationTest()
        {
            var rf = new ConfigurableRecordFinder(new DummyDatabase());
            var names = new string[] { "alpha", "gamma" };
            int tp = rf.GetTotalPopulation(names);
            Assert.Equal(4, tp);
        }
        [Fact]
        public void DIPopulationTest()
        {
            var cb = new ContainerBuilder();
            cb.RegisterType<OrdinaryDatabase>().As<IDatabase>()
                .SingleInstance();
            cb.RegisterType<ConfigurableRecordFinder>();

            using(var c = cb.Build())
            {
                var rf = c.Resolve<ConfigurableRecordFinder>();
                
            }
        }
    }
}
