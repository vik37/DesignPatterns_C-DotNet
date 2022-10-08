using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDP_UdemyDesignPatterns_ConsoleApp.MediatR_Demo
{
    public class PingCommand : IRequest<PongResponse>
    {
    }
}
