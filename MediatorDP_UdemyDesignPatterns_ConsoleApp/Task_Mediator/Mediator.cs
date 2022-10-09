using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorDP_UdemyDesignPatterns_ConsoleApp.Task_Mediator
{
    public class Mediator
    {
        public List<Participant> Participants = new List<Participant>();
               
        public void Broadcast()
        {

           if (Participants[0].SaidValues.Count > Participants[1].SaidValues.Count)
           {
               Participants[1].Value = Participants[0].SaidValues.Sum();
           }
           else
           {
               Participants[0].Value = Participants[1].SaidValues.Sum();
           }
        }
    }
}
