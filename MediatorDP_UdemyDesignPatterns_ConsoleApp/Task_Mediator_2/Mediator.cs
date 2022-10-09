using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDP_UdemyDesignPatterns_ConsoleApp.Task_Mediator_2
{
    public class Mediator
    {
        public void Broadcast(object sender, int n)
        {
            Alert?.Invoke(sender, n);
        }

        public event EventHandler<int> Alert;
    }
}
