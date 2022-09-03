using System;
using System.Collections.Generic;
using System.Text;

namespace UDemy_DesignnPattersAndPrinciples_ConsoleApp.InterfaceSegregation.interfaces
{
    public interface IMachine
    {
        void Print(Document d);
        void Scan(Document d);
        void Fax(Document d);
    }
}
