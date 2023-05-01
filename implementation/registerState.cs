using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mentoring_system.implementation
{
    internal class registerstate 
    { 
         public enum bookState
        {
            NONE,
            LOGIN,
            REGISTER,
            REGISTERED,
            LOGINED
        };
        public enum bookTrigger
        {
            OPEN_LOGIN_PAGE,
            OPEN_SIGNUP_PAGE,
            OPEN_DASHBOARD
        }
        bookState currentState = bookState.NONE;
        public class Transition
        {
            public bookState currentState;
            public bookState finalState;
            public bookTrigger trigger;
            public Transition(bookState currentState, bookState finalState, bookTrigger trigger)
            {
                this.currentState = currentState;
                this.finalState = finalState;
                this.trigger = trigger;
            }
        }
        Transition[] transisi ={
               new Transition(bookState.NONE,bookState.LOGIN, bookTrigger.OPEN_LOGIN_PAGE),
               new Transition(bookState.NONE,bookState.REGISTER, bookTrigger.OPEN_SIGNUP_PAGE),
               new Transition(bookState.REGISTER,bookState.REGISTERED, bookTrigger.OPEN_DASHBOARD),
               new Transition(bookState.LOGIN,bookState.LOGINED, bookTrigger.OPEN_DASHBOARD)
            };
        public bookState GetNextState(bookState currentState, bookTrigger trigger)
        {
            bookState finalState = currentState;
            for (int i = 0; i < transisi.Length; i++)
            {
                Transition change = transisi[i];
                if (currentState == change.currentState && trigger == change.trigger)
                {
                    finalState = change.finalState;
                }
            }
            return finalState;
        }
        public void ActivateTrigger(bookTrigger trigger)
        {
            Debug.Assert(Enum.IsDefined(typeof(bookTrigger), trigger), "not a valid value.");

            currentState = GetNextState(currentState, trigger);
            Console.WriteLine("Kondisi Booking Mentoring sekarang adalah " + currentState);
        }
    }
}
