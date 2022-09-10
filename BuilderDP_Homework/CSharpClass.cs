using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDP_Homework
{
    public class CSharpClass
    {
        public string Name, Type;
        public List<CSharpClass> CSharpClasses = new List<CSharpClass>();
        private const int indentSize = 2;
        public CSharpClass() { }
        public CSharpClass(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }
        private string ToStringImplement()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"public class {Name}");
            sb.AppendLine("{");
            var i = new string(' ', indentSize);
            foreach (var c in CSharpClasses)
            {
                sb.AppendLine($"{i}public {c.Type} {c.Name};");
            }
            sb.AppendLine("}");
            return sb.ToString();
        }
        public override string ToString()
        {
            return ToStringImplement();
        }
    }
}
