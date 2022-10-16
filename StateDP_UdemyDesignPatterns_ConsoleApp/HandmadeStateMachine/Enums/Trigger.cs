using System;
using System.Collections.Generic;
using System.Text;

namespace StateDP_UdemyDesignPatterns_ConsoleApp.HandmadeStateMachine.Enums
{
    public enum Trigger
    {
        CallDialed,
        HungUp,
        CallConnected,
        PlaceOnHold,
        TakenOffHold,
        LeftMessage
    }
}
