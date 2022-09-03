using System;
using System.Collections.Generic;
using System.Text;
using UDemy_DesignnPattersAndPrinciples_ConsoleApp.InterfaceSegregation.interfaces;

namespace UDemy_DesignnPattersAndPrinciples_ConsoleApp.InterfaceSegregation
{
    public class OldFationFilter : IMachine
    {
        public void Print(Document d)
        {
            //
        }
        public void Scan(Document d)
        {
            throw new NotImplementedException();
        }
        public void Fax(Document d)
        {
            throw new NotImplementedException();
        }
    }
}
