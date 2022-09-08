using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDP_UdemyDesignPatterns_ConsoleApp.FunctionalBuilder
{
    public static class PersonBuilderExtension
    {
        public static PersonBuild WorksAs(this PersonBuild builder, string position)
                                => builder.Do(p => p.Position = position);
    }
}
