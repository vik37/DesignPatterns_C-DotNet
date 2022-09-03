using System;
using System.Collections.Generic;
using System.Text;
using UDemy_DesignnPattersAndPrinciples_ConsoleApp.InterfaceSegregation.interfaces;

namespace UDemy_DesignnPattersAndPrinciples_ConsoleApp.InterfaceSegregation
{
    public class MultiFunctionMachine : IMultiFunctionDevice
    {
        private IPrinter Printer;
        private IScanner Scanner;
        public MultiFunctionMachine(IPrinter printer, IScanner scanner)
        {
            if(printer == null)
            {
                throw new ArgumentNullException(paramName: nameof(Printer));
            }
            if(scanner == null)
            {
                throw new ArgumentNullException(paramName: nameof(Scanner));
            }
            Printer = printer;
            Scanner = scanner;
        }
        public void Print(Document d)
        {
            Printer.Print(d);
        }

        public void Scan(Document d)
        {
            Scanner.Scan(d);
        }
    }
}
