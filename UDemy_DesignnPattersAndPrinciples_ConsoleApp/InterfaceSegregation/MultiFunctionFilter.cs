using System;
using System.Collections.Generic;
using System.Text;
using UDemy_DesignnPattersAndPrinciples_ConsoleApp.InterfaceSegregation.interfaces;

namespace UDemy_DesignnPattersAndPrinciples_ConsoleApp.InterfaceSegregation
{
    public class MultiFunctionFilter : IMachine
    {
        public void Print(Document d)
        {
            //
        }
        public void Scan(Document d)
        {
            //
        }
        public void Fax(Document d)
        {
            //
        }
    }
}
