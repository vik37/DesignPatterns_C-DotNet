using DecoratorDP_UdemyDesignPatterns_ConsoleApp.DecoratorInDI.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDP_UdemyDesignPatterns_ConsoleApp.DecoratorInDI
{
    public class ReportingServiceWithLogging : IReportingService
    {
        private readonly IReportingService decorated;
        public ReportingServiceWithLogging(IReportingService decorated)
        {
            this.decorated = decorated;
        }

        public void Report()
        {
            Console.WriteLine("Comming log...");
            decorated.Report();
            Console.WriteLine("Ending log...");
        }
    }
}
