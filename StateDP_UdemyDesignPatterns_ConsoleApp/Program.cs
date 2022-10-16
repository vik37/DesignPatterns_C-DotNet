//using StateDP_UdemyDesignPatterns_ConsoleApp.ClassicImplementation;
//using StateDP_UdemyDesignPatterns_ConsoleApp.HandmadeStateMachine.Enums;
//using StateDP_UdemyDesignPatterns_ConsoleApp.Switch_baseStateMachine.Enums;
using StateDP_UdemyDesignPatterns_ConsoleApp.SwitchExpression.Enums;
using System;
using System.Collections.Generic;
using System.Resources;
using System.Text;

namespace StateDP_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        #region Handmade State Machine
        //private static Dictionary<State, List<(Trigger,State)>> rules
        //    = new Dictionary<State, List<(Trigger, State)>>
        //    {
        //        [State.OffHook] = new List<(Trigger, State)>
        //        {
        //            (Trigger.CallDialed,State.Connecting)
        //        },
        //        [State.Connecting] = new List<(Trigger, State)>
        //        {
        //            (Trigger.HungUp, State.OffHook),
        //            (Trigger.CallConnected,State.Connected)
        //        },
        //        [State.Connected] = new List<(Trigger, State)>
        //        {
        //            (Trigger.LeftMessage,State.OffHook),
        //            (Trigger.HungUp,State.OffHook),
        //            (Trigger.PlaceOnHold,State.OnHold)
        //        },
        //        [State.OnHold] = new List<(Trigger, State)>
        //        {
        //            (Trigger.TakenOffHold, State.Connected),
        //            (Trigger.HungUp, State.OffHook)
        //        }
        //    };
        #endregion

        #region Switch Expressions
        static Chest Manipulate(Chest chest, Actions action, bool haveKey) =>
            (chest, action, haveKey) switch
            {
                (Chest.Locked, Actions.Open, true) =>
                    (chest, action, haveKey) switch
                    {
                        (Chest.Closed, Actions.Open, _) => Chest.Open,
                        (Chest.Locked, Actions.Open, true) => Chest.Open,
                        (Chest.Open, Actions.Close, true) => Chest.Locked,
                        (Chest.Open, Actions.Close, false) => Chest.Closed,
                        _ => chest
                    }
            };
        static Chest Manipulate2(Chest chest,
        Actions action, bool haveKey)
        {
            switch (chest, action, haveKey)
            {
                case (Chest.Closed, Actions.Open, _):
                    return Chest.Open;
                case (Chest.Locked, Actions.Open, true):
                    return Chest.Open;
                case (Chest.Open, Actions.Close, true):
                    return Chest.Locked;
                case (Chest.Open, Actions.Close, false):
                    return Chest.Closed;
                default:
                    Console.WriteLine("Chest unchanged");
                    return chest;
            }
        }
        #endregion
        static void Main(string[] args)
        {
            #region Classic Implementation
            //var ls = new Switch();
            //ls.On();
            //ls.Off();
            //ls.Off();
            #endregion

            #region Handmade State Machine
            //try
            //{
            //    var state = State.OffHook;
            //    while (true)
            //    {
            //        try
            //        {
            //            Console.WriteLine($"The phone is currently {state}");
            //            Console.WriteLine("Select a trigger: ");
            //            for (int i = 0; i < rules[state].Count; i++)
            //            {
            //                var (t, _) = rules[state][i];
            //                Console.WriteLine($"{i}. {t}");
            //            }
            //            int input = int.Parse(Console.ReadLine());
            //            var (_, s) = rules[state][input];
            //            state = s;
            //        }
            //        catch (ArgumentOutOfRangeException)
            //        {
            //            Console.WriteLine("Wrong Number.");
            //        }                    
            //    }
            //}            
            //catch (Exception ex)
            //{

            //    Console.WriteLine($"Some problem - msg {ex.Message}");
            //}                    
            #endregion

            #region Switch Base State Machine
            //string code = "1234";
            //var state = State.Locekd;
            //var entry = new StringBuilder();

            //while (true)
            //{
            //    switch (state)
            //    {
            //        case State.Locekd:
            //            entry.Append(Console.ReadKey().KeyChar);
            //            if(entry.ToString() == code)
            //            {
            //                state = State.Unlocked;
            //                break;
            //            }
            //            if (!code.StartsWith(entry.ToString()))
            //            {
            //                state = State.Failed;
            //            }
            //            break;
            //        case State.Failed:
            //            Console.CursorLeft = 0;
            //            Console.WriteLine("FAILED!!!");
            //            entry.Clear();
            //            state = State.Locekd;
            //            break;
            //        case State.Unlocked:
            //            Console.CursorLeft = 0;
            //            Console.WriteLine("UNLOCKED!!!");
            //            return;
            //    }
            //}
            #endregion

            #region Switch Expressions
            Chest chest = Chest.Locked;
            Console.WriteLine($"Chest is {chest}");

            chest = Manipulate(chest, Actions.Open, true);
            Console.WriteLine($"Chest is {chest}");

            chest = Manipulate(chest, Actions.Close, false);
            Console.WriteLine($"Chest is {chest}");

            chest = Manipulate(chest, Actions.Close, false);
            Console.WriteLine($"Chest is {chest}");
            #endregion
            Console.ReadLine();
        }
    }
}
