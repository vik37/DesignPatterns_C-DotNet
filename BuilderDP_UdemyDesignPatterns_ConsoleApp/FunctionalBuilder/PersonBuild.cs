using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderDP_UdemyDesignPatterns_ConsoleApp.FunctionalBuilder
{
    //public sealed class PersonBuild
    //{
    //    private readonly List<Func<Person, Person>> actions
    //        = new List<Func<Person, Person>>();
    //    public PersonBuild Called(string name)
    //        => Do(p => p.Name = name);
    //    public PersonBuild Do(Action<Person> action)
    //        => AddAction(action);
    //    public Person Build()
    //        => actions.Aggregate(new Person(), (p, f) => f(p));
    //    private PersonBuild AddAction(Action<Person> action)
    //    {
    //        actions.Add(p =>
    //        {
    //            action(p);
    //            return p;
    //        });
    //        return this;
    //    }
    //}
}
