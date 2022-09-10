using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDP_Homework
{
    public class CodeBuilder
    {
        
        CSharpClass root = new CSharpClass();
        public CodeBuilder(string className)
        {
            root.Name = className;
        }
        public CodeBuilder AddField(string fieldName, string fieldType)
        {
            var cSharpClass = new CSharpClass(fieldName, fieldType);
            root.CSharpClasses.Add(cSharpClass);
            return this;
        }
        public override string ToString()
        {
            return root.ToString();
        }
    }
}
