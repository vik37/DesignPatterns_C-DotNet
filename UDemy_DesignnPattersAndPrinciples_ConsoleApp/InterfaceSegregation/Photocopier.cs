using System;
using System.Collections.Generic;
using System.Text;
using UDemy_DesignnPattersAndPrinciples_ConsoleApp.InterfaceSegregation.interfaces;

namespace UDemy_DesignnPattersAndPrinciples_ConsoleApp.InterfaceSegregation
{
    public class Photocopier : IPrinter, IScanner
    {
        public void Print(Document d)
        {
            throw new NotImplementedException();
        }

        public void Scan(Document d)
        {
            throw new NotImplementedException();
        }
    }
}
