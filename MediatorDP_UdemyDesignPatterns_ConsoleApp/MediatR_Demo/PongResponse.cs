using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDP_UdemyDesignPatterns_ConsoleApp.MediatR_Demo
{
    public class PongResponse
    {
        public DateTime Timestamp;
        public PongResponse(DateTime timestamp)
        {
            Timestamp = timestamp;
        }
    }
}
