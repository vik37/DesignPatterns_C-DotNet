using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace UDemy_DesignnPattersAndPrinciples_ConsoleApp.InterfaceSegregation.interfaces
{
    public interface IScanner
    {
        void Scan(Document d);
    }
}
