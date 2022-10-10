using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectDP_UdemyDesignPatterns_ConsoleApp.Task
{
    public class Account
    {
        private ILog log;

        public Account(ILog log)
        {
            this.log = log;
        }

        public void SomeOperation()
        {
            try
            {
                int c = log.RecordCount;
                log.LogInfo("Performing an operation");
                if (c + 1 != log.RecordCount)
                    throw new Exception();
                if (log.RecordCount >= log.RecordLimit)
                    throw new Exception();
            }
            catch (Exception ex)
            {
                log.LogInfo(ex.Message);
            }
            
        }
    }
}
