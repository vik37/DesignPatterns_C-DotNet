//using StateDP_UdemyDesignPatterns_ConsoleApp.ClassicImplementation;
using StateDP_UdemyDesignPatterns_ConsoleApp.HandmadeStateMachine.Enums;
using System;
using System.Collections.Generic;

namespace StateDP_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        #region Handmade State Machine
        private static Dictionary<State, List<(Trigger,State)>> rules
            = new Dictionary<State, List<(Trigger, State)>>
            {
                [State.OffHook] = new List<(Trigger, State)>
                {
                    (Trigger.CallDialed,State.Connecting)
                },
                [State.Connecting] = new List<(Trigger, State)>
                {
                    (Trigger.HungUp, State.OffHook),
                    (Trigger.CallConnected,State.Connected)
                },
                [State.Connected] = new List<(Trigger, State)>
                {
                    (Trigger.LeftMessage,State.OffHook),
                    (Trigger.HungUp,State.OffHook),
                    (Trigger.PlaceOnHold,State.OnHold)
                },
                [State.OnHold] = new List<(Trigger, State)>
                {
                    (Trigger.TakenOffHold, State.Connected),
                    (Trigger.HungUp, State.OffHook)
                }
            };
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
            try
            {
                var state = State.OffHook;
                while (true)
                {
                    try
                    {
                        Console.WriteLine($"The phone is currently {state}");
                        Console.WriteLine("Select a trigger: ");
                        for (int i = 0; i < rules[state].Count; i++)
                        {
                            var (t, _) = rules[state][i];
                            Console.WriteLine($"{i}. {t}");
                        }
                        int input = int.Parse(Console.ReadLine());
                        var (_, s) = rules[state][input];
                        state = s;
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Wrong Number.");
                    }                    
                }
            }            
            catch (Exception ex)
            {

                Console.WriteLine($"Some problem - msg {ex.Message}");
            }
            
            
            #endregion
            Console.ReadLine();
        }
    }
}
